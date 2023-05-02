using RabbitMQ.Client;

ConnectionFactory factory = new();
factory.Uri = new Uri(uriString: "amqp://guest:guest@localhost:5672");
factory.ClientProvidedName = "Rabbit Sender App";  

IConnection cnn = factory.CreateConnection();

IModel channel = cnn.CreateModel();

string exchangeName = "DemoExchange";
string routingKey = "demo-routing-key";
string queueName = "DemoQueue";