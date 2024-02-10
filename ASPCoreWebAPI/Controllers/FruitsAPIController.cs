using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPCoreWebAPI.Controllers
{
    [Route("api/[controller]")]//Attribute Routing
    [ApiController]//
    public class FruitsAPIController : ControllerBase
    {
        public List<string> fruits = new List<string>()
        {
          "Apple",
          "Mango",
          "Cherry",
          "Banana",
          "Grapes"
        };
        [HttpGet]//get request for this api
        //url=https://localhost:7205/api/FruitsAPI
        // Now creating an action method to handle this api
        public List<string> GetFruits()
        {
            return fruits;
        }
        [HttpGet("{id}")]//url=https://localhost:7205/api/FruitsAPI/id
        public string GetFruitsById(int id)
        {
            if(fruits.Count<=id||id<0)
            {
                return "Invalid index as there is nosuch fruit in this index";
            }
            return fruits[id];
        }
        [HttpPost("{FruitsName}")]
        public List<string>PostFruits(string FruitsName)
        {
            fruits.Add(FruitsName);
            return fruits;
        }
        [HttpPut("{id,FruitName}")]
        public string UpdatedFruitByIdAndName(int id, string FruitName)
        {
            if (fruits.Count <= id || id < 0)
            {
                return "Invalid index as there is nosuch fruit in this index";
            }
            return fruits[id] = FruitName;
        }
        [HttpDelete("{id}")]
        public void DeletedFruitById(int id)
        {
            if (fruits.Count <= id || id < 0)
            {
                return;
            }
            fruits.Remove(fruits[id]);
        }
        

    }
}
