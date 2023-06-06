using Azure.Identity;
using Microsoft.Azure.Cosmos;
using ApiCuentos.Models; 


namespace ApiCuentos.Services
{
  
    public class CosmosService
    {
        private readonly Container container;
        public CosmosService() 
        {
            // New instance of CosmosClient class
            CosmosClient client = new(
                accountEndpoint: "https://cosmos-apicuentos.documents.azure.com:443/",
                tokenCredential: new DefaultAzureCredential()
            );
            Database database = client.GetDatabase("cosmosapicuentos");

         container = database.GetContainer("cuentos");

        }


        public async Task<Product> CreateItemAsync()
        {// Create new object and upsert (create or replace) to container
            Product newItem = new(
                        id: Guid.NewGuid().ToString(),
                        categoryId: "/id",
                        categoryName: "gear-surf-surfboards",
                        name: "Yamba Surfboard",
                        quantity: 12,
                        sale: false
                    );


            Product createdItem = await container.CreateItemAsync<Product>(
                item: newItem,
                partitionKey: new PartitionKey(newItem.id)
            );

            Console.WriteLine($"Created item:\t{createdItem.id}\t[{createdItem.categoryName}]");

            return createdItem;
        }


              public string GetMensaje()
        {
            string msj = "Hello world";
            return msj;
        }

    }
}