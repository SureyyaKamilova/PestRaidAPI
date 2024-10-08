﻿using Core.Helpers.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAboutService
    {
        IResult AddAbout(About about);
        IResult DeleteAbout(About about);
        IResult UpdateAbout(About about);
        IDataResult<List<About>> GetAllAbouts();
        IDataResult<About> Get(int id);
    }
}
