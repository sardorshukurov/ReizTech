using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Branch
    {
        List<Branch> _branches;

        public Branch() 
        {
            _branches = new List<Branch>();
        }

        public void AddBranch(Branch branch)
        {
            _branches.Add(branch);
        }

        public List<Branch> GetBranches()
        {
            return _branches;
        }
    }
}
