using Bussiness.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    //çıplak class kalmamalı
    //encapsulation-kapsülleme.(Person u kullandık)
    public class PersonManager : IApplicantService
    {
        //public void ApplyForMask(Person person )
        //{ //string firstname, vs yazılabilirdi ama işlevsel değil
        //  //sıklıkla kullanılan operasyonları bburaya yaz


        //}

        //public List<Person> GetAll()
        //{
        //    return null;
        //}

        //public bool CheckPerson( Person person )
        //{
        //    //mernisten alcak
        //    return true;
        //}
        public void ApplyForMask(Person person)
        {
            throw new NotImplementedException();
        }

        public  bool CheckPerson(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest
                (new TCKimlikNoDogrulaRequestBody(person.NationalIdentity
                , person.FirstName, person.LastName, person.DateOfBirth))
                ).Result.Body.TCKimlikNoDogrulaResult;
        }

        public List<Person> GetList()
        {
            return null;
        }
    }
}
