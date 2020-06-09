using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//using ExifLib;
using MetaMusic;
using MetadataExtractor;

namespace Proyecto
{
    public class MetaDataController
    {
        public Dictionary<string, string> ReadMeta(string filename, string type)
        {
            
            Stream stream = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.None);
            if (type == "song")
            {
                IEnumerable<MetadataExtractor.Directory> dSong = MetadataExtractor.Formats.QuickTime.QuickTimeMetadataReader.ReadMetadata(stream);
                stream.Close();
                return MetaToDict(dSong);
            }
            else
            {
                IEnumerable<MetadataExtractor.Directory> dVideo = ImageMetadataReader.ReadMetadata(filename);
                stream.Close();
                return MetaToDict(dVideo);
            }

            
            

            
        }


        public Dictionary<string, string> MetaToDict(IEnumerable<MetadataExtractor.Directory> directories)
        {
            Dictionary<string, string> meta = new Dictionary<string, string>();
            foreach (var directory in directories)
            {
                foreach (var tag in directory.Tags)
                {
                    if (true)//meta.ContainsKey(tag.Name) == false)
                    {
                        meta.Add($"{directory.Name}{tag.Name}", tag.Description);
                    }

                }
            }
            return meta;
        }

        public Dictionary<string, string> MetaManual(string filename, string type)
        {
            List<string> TagList = new List<string>();
            Dictionary<string, string> meta = new Dictionary<string, string>();
            meta.Add("File name", filename);
            meta.Add("Format", "");
            meta.Add("Duration HH:MM:SS", "");
            if (type == "song")
            {
                meta.Add("Name", "");
                meta.Add("Artist", "");
                meta.Add("Album", "");
                meta.Add("Genre", "");
                meta.Add("Release Year", "");
                meta.Add("Label", "");
                meta.Add("Lyrics", "");
            }

            else if (type == "video")
            {
                meta.Add("Name", "");
                meta.Add("Creator", "");
                meta.Add("Genre", "");
                meta.Add("Category", "");
                meta.Add("Actors", "");
                meta.Add("Director", "");
                meta.Add("Studio", "");
                meta.Add("Release Year", "");
                meta.Add("Description", "");
                meta.Add("Resolution", "");
                meta.Add("Aspect Ratio", "");

            }




            return meta;
        }





















        //public static Dictionary<string, string> ReadMeta(string filename)
        //{
        //    //Process a = new Process();
        //    //;
        //    //ProcessStartInfo me = new ProcessStartInfo("exiftool(-k)", $"{filename}\n");
        //    //me.RedirectStandardOutput = true;
        //    //me.UseShellExecute = false;
        //    //me.CreateNoWindow = true;
        //    //a = Process.Start(me);
        //    ////Thread.Sleep(2000);
        //    //StreamReader meta = a.StandardOutput;
        //    //string line;
        //    //Dictionary<string, string> metadata = new Dictionary<string, string>();


        //    //while ((line = meta.ReadLine()) != null)
        //    //{
        //    //    string[] val = line.Split(':');
        //    //    metadata.Add(val[0].Trim(), val[1].Trim());

        //    //}/*
        //    //string[] dkey = new string[] { filename, "-execute" };
        //    //foreach (string line in a.StandardOutput.ReadLine())
        //    //{
        //    //    string[] val = line.Split(':');
        //    //    Console.WriteLine(val);
        //    //    metadata.Add(val[0].Trim(), val[1].Trim());
        //    //}*/

        //    //a.Dispose();
        //    //return metadata;
        //}

        //    bool ExifToolHasBeenLoaded = false;
        //    Process pExifTool = new Process();

        //    private void RunExiftoolWhileStayingOpen()
        //    {
        //        //  Start ExifTool and keep it in memory if that has not been done yet.
        //        if (!ExifToolHasBeenLoaded)
        //        {
        //            string command = "\"" + ExifToolFolderPath + "exiftool.exe\" -stay_open true -@ args.txt";

        //            pExifTool.StartInfo = new ProcessStartInfo("cmd", String.Format("/c \"{0}\"", @command));
        //            pExifTool.StartInfo.RedirectStandardOutput = true;

        //            //  NOTE:  If you do not implement an asynchronous error handler like in this example, instead simply using pExifTool.StandardError.ReadLine()
        //            //         in the following, you risk that your program might stall.  This is because ExifTool sometimes reports failure only through a
        //            //         StandardOutput line saying something like "0 output files created" without reporting anything in addition via StandardError, so
        //            //         pExifTool.StandardError.ReadLine() would wait indefinitely for an error message that never comes.
        //            pExifTool.StartInfo.RedirectStandardError = true;
        //            pExifTool.ErrorDataReceived += new DataReceivedEventHandler(ETErrorHandler);

        //            pExifTool.StartInfo.UseShellExecute = false;
        //            pExifTool.StartInfo.CreateNoWindow = true;
        //            pExifTool.Start();
        //            pExifTool.BeginErrorReadLine();  //  This command starts the error handling, meaning ETErrorHandler() will now be called whenever ExifTool reports an error.

        //            ExifToolHasBeenLoaded = true;
        //        }

        //        //  Append the args file for Exiftool to start reading and executing the command.
        //        //  NOTE:  NEVER use WriteAllLines here - ExifTool expects the args file to be appended continually, not re-written. 

        //        string[] args = new string[] { ImageFileName, "-execute" };  //  This tells ExifTool to read out all of the image's metadata.
        //        File.AppendAllLines(ExifToolFolderPath + "args.txt", args);  //  args.txt gets written into the folder where exiftool.exe resides here.

        //        string line;
        //        do
        //        {
        //            line = pExifTool.StandardOutput.ReadLine();

        //            //  NOTE:  Depending on the command you issued, line will either contain a progress report of an operation (e.g., "1 output files created"), 
        //            //         give line-by-line data, such as an image's metadata (e.g. "Orientation                     : Horizontal (normal)"), or 
        //            //         read "{ready}", which indicates that executing the last command in args.txt has completed. 

        //            ...  do something with the information provided in line...
        //    }
        //        while (!line.Contains("{ready}"));

        //        //  At this point, you can issue the next command for ExifTool, following the very same approach.  For instance, this tells ExifTool to 
        //        //  extract a PreviewImage from a RAW image, using the trick of adding "%0f" at the beginning of the new filename as a way to 
        //        //  give the PreviewImage a different name from the orginal file ...
        //        args = new string[] { "-b", "-PreviewImage", "-w", ImagePreviewFolderPath + "%0f" + ImagePreviewFileName, RAWImageFileName, "-execute" };
        //        File.AppendAllLines(ExifToolFolderPath + "args.txt", args);

        //        ...  read and process pExifTool.StandardOutput again as per the above ...

        //    //  ... and this starts the conversion of an appropriate original image, for instance a .NEF, to .JPG:
        //    args = new string[] { "-b", "-JpgFromRaw", "-w", JPGImageFolderPath + "%0f" + JPGImageName, RAWImageFileName, "-execute" };
        //        File.AppendAllLines(ExifToolFolderPath + "args.txt", args);

        //        ...  read and process pExifTool.StandardOutput again as per the above ...
        //}


        //    //  Finally, this is the asynchronous error handler

        //    private void ETErrorHandler(object sendingProcess, DataReceivedEventArgs errLine)
        //    {
        //        if (!String.IsNullOrEmpty(errLine.Data))
        //        {
        //            ...  do something with the information provided in errLine.Data...
        //    }
        //    }




    }
}
