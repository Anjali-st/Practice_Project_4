﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp_Oop_School_Data_Design_Practice_Project
{
    public interface ITeacherObserver
    {
        void Update(ISubject subject);
    }
}
