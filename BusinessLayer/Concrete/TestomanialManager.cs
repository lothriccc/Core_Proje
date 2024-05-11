using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessLayer.Concrete
{
    public class TestomanialManager : ITestomanialService
    {
        ITestomanialDal _testomanialDal;

        public TestomanialManager(ITestomanialDal testomanialDal)
        {
            _testomanialDal = testomanialDal;
        }

        public void TAdd(Testomanial t)
        {
            _testomanialDal.Insert(t);
        }

        public void TDelete(Testomanial t)
        {
            _testomanialDal.Delete(t);
        }

        public Testomanial TGetByID(int id)
        {
            return _testomanialDal.GetByID(id);
        }

        public List<Testomanial> TGetList()
        {
            return _testomanialDal.GetList();
        }

		public List<Testomanial> TGetListByFilter(string p)
		{
			throw new NotImplementedException();
		}

		public void TUpdate(Testomanial t)
        {
            _testomanialDal.Update(t);
        }
    }
}
