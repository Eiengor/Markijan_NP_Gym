﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markijan_NP_T1.Repositories.Abstract
{
    public interface IReposFactory
    {
        IMembershipRep GetMembershipRep();
        IMemberRep GetMemberRep();
    }
}
