using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Markijan_NP_T1.Models;

namespace Markijan_NP_T1.Services.Abstract
{
    public interface IMemberService
    {
        Member GetOldestMember(List<Member> members);
    }
}
