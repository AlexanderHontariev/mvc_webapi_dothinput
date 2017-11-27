using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace AjaxImageLoader.Models
{

    public class ImageList {

        static ImageList _imageList = new ImageList();

        List<Image> _data = new List<Image> {
            new Image{ Id = 1, AltText = "img 1", ImageName = "img-1.jpg", Width=200, Height=400, CreationDate = DateTime.Now, LastModefied = DateTime.Now },
            new Image{ Id = 2, AltText = "img 2", ImageName = "img-2.jpg", Width=200, Height=400, CreationDate = DateTime.Now, LastModefied = DateTime.Now },
            new Image{ Id = 3, AltText = "img 3", ImageName = "img-3.jpg", Width=200, Height=400, CreationDate = DateTime.Now, LastModefied = DateTime.Now },
            new Image{ Id = 4, AltText = "img 4", ImageName = "img-4.jpg", Width=200, Height=400, CreationDate = DateTime.Now, LastModefied = DateTime.Now },
            new Image{ Id = 5, AltText = "img 5", ImageName = "img-5.jpg", Width=200, Height=400, CreationDate = DateTime.Now, LastModefied = DateTime.Now },
            new Image{ Id = 6, AltText = "img 6", ImageName = "img-6.jpg", Width=200, Height=400, CreationDate = DateTime.Now, LastModefied = DateTime.Now },
            new Image{ Id = 7, AltText = "img 7", ImageName = "img-7.jpg", Width=200, Height=400, CreationDate = DateTime.Now, LastModefied = DateTime.Now },
            new Image{ Id = 8, AltText = "img 8", ImageName = "img-8.jpg", Width=200, Height=400, CreationDate = DateTime.Now, LastModefied = DateTime.Now },
            new Image{ Id = 9, AltText = "img 9", ImageName = "img-9.jpg", Width=200, Height=400, CreationDate = DateTime.Now, LastModefied = DateTime.Now },
            new Image{ Id = 10, AltText = "img 10", ImageName = "img-10.jpg", Width=200, Height=400, CreationDate = DateTime.Now, LastModefied = DateTime.Now },
            new Image{ Id = 11, AltText = "img 11", ImageName = "img-11.jpg", Width=200, Height=400, CreationDate = DateTime.Now, LastModefied = DateTime.Now },
            new Image{ Id = 12, AltText = "img 12", ImageName = "img-12.jpg", Width=200, Height=400, CreationDate = DateTime.Now, LastModefied = DateTime.Now },
            new Image{ Id = 13, AltText = "img 13", ImageName = "img-13.jpg", Width=200, Height=400, CreationDate = DateTime.Now, LastModefied = DateTime.Now },
            new Image{ Id = 14, AltText = "img 14", ImageName = "img-14.jpg", Width=200, Height=400, CreationDate = DateTime.Now, LastModefied = DateTime.Now },
            new Image{ Id = 15, AltText = "img 15", ImageName = "img-15.jpg", Width=200, Height=400, CreationDate = DateTime.Now, LastModefied = DateTime.Now },
            new Image{ Id = 16, AltText = "img 16", ImageName = "img-16.jpg", Width=200, Height=400, CreationDate = DateTime.Now, LastModefied = DateTime.Now },

        };

        public int Length { get { return _data.Count(); } }

        static public ImageList Curent {
            get { return _imageList; }
        }

        public List<Image> GetAll()
        {
            return _data;
        }

        public List<Image> GetInterval(int skip, int take)
        {
            return _data.Skip(skip)
                        .Take(take)
                        .OrderByDescending(img => img.Id)
                        .ToList();
        }

        public Image GetImage (int id)
        {
            return _data.Where(img => img.Id == id).FirstOrDefault();
        }

        public bool CreateImage (Image item)
        {
            if (item != null)
            {
                item.Id = _data.Count() + 1;
                _data.Add(item);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Image RemoveImage (int id)
        {
            Image img = GetImage(id);
            
            if (img != null)
            {
                _data.Remove(img);
                return img;
            } else
            {
                return null;
            }
        }
    }

    public class Image
    {
        public int Id { get; set; }
        public string ImageName { get; set; }
        public string AltText { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastModefied { get; set; }
    }
}