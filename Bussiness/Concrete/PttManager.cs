using Bussiness.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class PttManager : ISupplierService
    {
        //ihtiyaç duyuduğum sınıfı newlemek yerine onun interface ini yazıyorum.
        
        private IApplicantService _applicantService;
        //classın başlaması için constructarını yazıyorum.newlendiğinde çalışır
        public PttManager(IApplicantService applicantserver)
        {
            _applicantService= applicantserver;
        }
        public void GiveMask(Person person)
        {
            
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + "için maske verildi");
            }
            else
            {
                Console.WriteLine(person.FirstName + "için maske verilemedi");
            }
        }
    }
}
