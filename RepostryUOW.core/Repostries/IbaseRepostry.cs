﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepostriyUOW.core.Repostries
{
    public interface IBaseRepostry<T> where T : class
    {
        T GetById(int id);
    }
}
