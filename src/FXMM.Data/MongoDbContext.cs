using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using Microsoft.Extensions.Options;
using FXMM.Entity;

namespace FXMM.Data
{
    public class MongoDbContext
    {
        //public static string ConnectionString { get; set; }
        //public static string DatabaseName { get; set; } = "aip";
        //public static bool ISSSL { get; set; }

        private const string _BANKCOLLECTION = "bank";
        private const string _ACCRUEDBASISCOLLECTION = "accruedbasis";
        private const string _BRANCHCOLLECTION = "branch";
        private const string _CITYCOLLECTION = "city";
        private const string _COUNTERPARTYCOLLECTION = "counterparty";
        private const string _COUNTRYCOLLECTION = "country";
        private const string _CURRENCYCOLLECTION = "currency";
        private const string _CURRENCYPROFILECOLLECTION = "currencyprofile";
        private const string _FXTYPECOLLECTION = "fxtype";
        private const string _HOLIDAYCOLLECTION = "holiday";
        private const string _LEGALENTITYCOLLECTION = "legalentity";
        private const string _PAYMENTTYPECOLLECTION = "paymenttype";
        private const string _PORTFOLIOCOLLECTION = "portfolio";
        private const string _ROLECOLLECTION = "role";
        private const string _THIRDPARTYCOLLECTION = "thirdparty";
        private const string _USERGROUPCOLLECTION = "usergroup";
        private const string _USERINFOCOLLECTION = "userinfo";
        private const string _DEALMASTERCOLLECTION = "dealmaster";
        private const string _BONDCOLLECTION = "bond";

        private static IMongoDatabase _database = null;

        public IMongoDatabase Database
        {
            get { return _database; }
        }

        public MongoDbContext(IOptions<MongoDbSettings> settings)
        {
            var mongoClient = new MongoClient(settings.Value.ConnectionString);
	        if (mongoClient != null)
                    _database = mongoClient.GetDatabase(settings.Value.Database);
        }

        public IMongoCollection<Bank> BankCollection
        {
            get
            {
                return _database.GetCollection<Bank>(_BANKCOLLECTION);
            }
        }

        public IMongoCollection<AccruedBasis> AccruedBasisCollection
        {
            get
            {
                return _database.GetCollection<AccruedBasis>(_ACCRUEDBASISCOLLECTION);
            }
        }

        public IMongoCollection<Branch> BranchCollection
        {
            get
            {
                return _database.GetCollection<Branch>(_BRANCHCOLLECTION);
            }
        }

        public IMongoCollection<City> CityCollection
        {
            get
            {
                return _database.GetCollection<City>(_BRANCHCOLLECTION);
            }
        }

        public IMongoCollection<CounterParty> CityPartyCollection
        {
            get
            {
                return _database.GetCollection<CounterParty>(_COUNTERPARTYCOLLECTION);
            }
        }
    }
}
