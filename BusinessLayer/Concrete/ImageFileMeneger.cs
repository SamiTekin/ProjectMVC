﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ImageFileMeneger:IImageFileService
    {
        IImageFileDal _imageDal;

        public ImageFileMeneger(IImageFileDal imageDal)
        {
            _imageDal = imageDal;
        }

        public List<ImageFile> GetList()
        {
            return _imageDal.List();
        }

    }
}
