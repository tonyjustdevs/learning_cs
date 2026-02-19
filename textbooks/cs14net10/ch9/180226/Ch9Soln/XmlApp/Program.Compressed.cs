using System.IO.Compression;

partial class Program
{
    static GZipStream DoGZipCompressionOfFileStream(FileStream fs)
    {
        return new GZipStream(fs,mode: CompressionMode.Compress,leaveOpen:false);
    }

    static GZipStream DoGZipDeCompressionofFS(FileStream fs)
    {
        return new GZipStream(fs, mode: CompressionMode.Decompress, false);
    }


    //GZipStream()
}
