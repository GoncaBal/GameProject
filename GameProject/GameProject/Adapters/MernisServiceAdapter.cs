using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;
using MernisServiceReference;

namespace GameProject.Adapters
{
    public class MernisServiceAdapter : IUserValidationService
    {

        public bool Validate(User user)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return  client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(user.NationalityId, user.FirstName.ToUpper(), user.LastName.ToUpper(), user.BirthYear.Year))).Result.Body.TCKimlikNoDogrulaResult;

        }
    }
}
