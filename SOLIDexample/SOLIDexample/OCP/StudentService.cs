using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDexample.OCP
{
    internal class StudentService
    {
        public IRepository Repo { get; set; }
        public StudentService(IRepository repo)
        {
            Repo= repo;
        }
        public void Add()
        {
            Repo.Write();
        }
        public void Remove()
        {
            Repo.Write();

        }

        public void Get()
        {
            Repo.Read();
        }

    }
}
