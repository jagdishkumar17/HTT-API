using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.IO;

namespace HTT.Helpers
{
    /// <summary>
    /// Application file details
    /// </summary>
    public class AppFileDetail
    {
        /// <summary>
        /// Uploaded file base path
        /// </summary>
        readonly string _basePath = Path.Combine(AppHelper.HostingEnvironment.ContentRootPath, @"Content\Uploads");

        /// <summary>
        /// File info
        /// </summary>
        private readonly FileInfo _filInfo;

        /// <summary>
        /// Ctor used for getting the file
        /// </summary>
        /// <param name="file"></param>
        public AppFileDetail(HTT.Models.FileDetail file)
        {
            FileId = file.Id;
            Name = file.FileName;
            UploadedName = file.Id.ToString() + Path.GetExtension(file.FileName);

            var filePath = Path.Combine(_basePath, UploadedName);
            IsExist = File.Exists(filePath);
            if (!IsExist) // if file not found then default file image            
                filePath = Path.Combine(_basePath, "NoFile.png");

            _filInfo = new FileInfo(filePath);
            Length = _filInfo.Length;
            LastModified = _filInfo.CreationTime;
        }

        /// <summary>
        /// Ctor used for setting/saving the file
        /// </summary>
        /// <param name="file"></param>
        public AppFileDetail(IFormFile file)
        {
            Length = file.Length;
            if (Length > 0)
            {
                IsExist = true;
                FileId = Guid.NewGuid();
                Name = file.FileName;
                UploadedName = FileId.ToString() + Path.GetExtension(Name);
                fileToSave = file;
            }
        }

        /// <summary>
        /// File to byte array
        /// </summary>
        /// <returns></returns>
        public byte[] FileToByteArray()
        {
            byte[] _Buffer = null;

            try
            {
                // Open file for reading
                System.IO.FileStream _FileStream = new System.IO.FileStream(_filInfo.FullName, System.IO.FileMode.Open, System.IO.FileAccess.Read);

                // attach filestream to binary reader
                System.IO.BinaryReader _BinaryReader = new System.IO.BinaryReader(_FileStream);

                // get total byte length of the file
                long _TotalBytes = _filInfo.Length;

                // read entire file into buffer
                _Buffer = _BinaryReader.ReadBytes((Int32)_TotalBytes);

                // close file reader
                _FileStream.Close();
                _FileStream.Dispose();
                _BinaryReader.Close();
            }
            catch (Exception _Exception)
            {
                // Error
                Console.WriteLine("Exception caught in process: {0}", _Exception.ToString());
            }

            return _Buffer;
        }

        /// <summary>
        /// Save file in directory
        /// </summary>
        public void SaveFile()
        {
            try
            {
                var contentDirectoryPath = Path.Combine(AppHelper.HostingEnvironment.ContentRootPath, @"Content");
                if (!Directory.Exists(contentDirectoryPath))
                    Directory.CreateDirectory(contentDirectoryPath);

                var uploadDirectoryPath = Path.Combine(AppHelper.HostingEnvironment.ContentRootPath, @"Content\Uploads");
                if (!Directory.Exists(uploadDirectoryPath))
                    Directory.CreateDirectory(uploadDirectoryPath);

                var filePath = Path.Combine(_basePath, UploadedName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    fileToSave.CopyTo(fileStream);
                }
            }
            catch (Exception _Exception)
            {
                Console.WriteLine("Exception caught in process: {0}", _Exception.ToString());
            }
        }

        /// <summary>
        /// Delete file from directory
        /// </summary>
        public void DeleteFile()
        {
            try
            {
                if (_filInfo != null)
                {
                    File.Delete(Path.Combine(_basePath, UploadedName));
                }
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
            }
        }
        /// <summary>
        /// Ctor used for copy the same file to upload with different id
        /// </summary>
        /// <param name="file"></param>
        /// <param name="newFileId"></param>
        public void CopyFile(HTT.Models.FileDetail file, string newFileId)
        {
            string fileExt = Path.GetExtension(file.FileName);
            string sourceFile = Path.Combine(_basePath, file.Id + fileExt);
            IsExist = File.Exists(sourceFile);
            if (!IsExist) // if file not found then default file image            
                sourceFile = Path.Combine(_basePath, "NoFile.png");
            string destFile = Path.Combine(_basePath, newFileId + fileExt);
            File.Copy(sourceFile, destFile, true);
        }
        /// <summary>
        /// Check file exist or not
        /// </summary>
        public bool IsExist { get; set; }

        /// <summary>
        /// File uploded or changed name
        /// </summary>
        public string UploadedName { get; }

        /// <summary>
        /// File length
        /// </summary>
        public long Length { get; }

        /// <summary>
        /// File Name
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Last modified date of file
        /// </summary>
        public DateTimeOffset LastModified { get; }

        /// <summary>
        /// Base 64 string
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// File id
        /// </summary>
        public Guid FileId { get; set; }

        /// <summary>
        /// Just to keep the refence of existing file
        /// </summary>
        [JsonIgnore]
        public IFormFile fileToSave { get; set; }

    }
}