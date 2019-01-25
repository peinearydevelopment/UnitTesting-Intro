using Newtonsoft.Json;
using System;

namespace lib
{
    public class Client
    {
        protected IDataStore DataStore { get; }

        public Client(IDataStore dataStore)
        {
            DataStore = dataStore;
        }

        public Contract Save(Contract contract)
        {
            if (IsValidContract(contract))
            {
                var dtoToSave = ConvertToDto(contract);
                var dtoSaved = DataStore.Save(dtoToSave);
                return ConvertToContract(dtoSaved);
            }

            throw new Exception("Contract isn't valid");
        }

        // 1
        private Contract ConvertToContract(Dto dto)
        {
            return new Contract
            {
                Id = dto.Id,
                KeyWords = JsonConvert.DeserializeObject<KeyWord[]>(dto.KeywordsBlob)
            };
        }

        //// 2
        //private Contract ConvertToContract(Dto dto)
        //{
        //    return new Contract
        //    {
        //        Id = dto.Id,
        //        KeyWords = dto.KeywordsBlob == null ? null : JsonConvert.DeserializeObject<KeyWord[]>(dto.KeywordsBlob)
        //    };
        //}

        //// 3
        //private Contract ConvertToContract(Dto dto)
        //{
        //    return new Contract
        //    {
        //        Id = dto.Id,
        //        KeyWords = JsonConvert.DeserializeObject<KeyWord[]>(dto.KeywordsBlob)
        //    };
        //}

        private Dto ConvertToDto(Contract contract)
        {
            return new Dto
            {
                Id = contract.Id,
                KeywordsBlob = JsonConvert.SerializeObject(contract.KeyWords)
            };
        }

        private bool IsValidContract(Contract contract)
        {
            return true;
        }

        //// 3
        //private bool IsValidContract(Contract contract)
        //{
        //    return contract.KeyWords != null;
        //}
    }
}
