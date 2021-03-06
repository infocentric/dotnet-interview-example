﻿using IC.DotNet.Interview.Logic.Models;
using System.Collections.Generic;

namespace IC.DotNet.Interview.Logic.BL
{
    public interface ITaskLogic
    {
        IEnumerable<TaskViewModel> Get();
        TaskViewModel Get(string id);
        bool Add(TaskViewModel task);
        bool Edit(string id, TaskViewModel task);
        bool Delete(string id, TaskViewModel task);
    }
}
