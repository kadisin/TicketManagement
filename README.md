<!DOCTYPE html>
<html>
<head>
</head>
<body style="margin: auto; text-align: center;">
    
<h2>Ticket Management Backend</h2>
<p />
<h3>Paragraphs</h3>
<li>About project</li>
<li>Application architecture</li>
<li>CQRS and Mediator patterns</li>
<li>Dependency Injection</li>
<li>Exception handling and logging</li>
    
<hr>
<h3>Project Information</h3>
<li>Application created to learn good backend practises</li>
<li>Application use .NET Framework, Entity Framework, Mappers, CQRS Architecture, Communication mediator</li>
<li>Dependency injection</li>
<li>Application handle exceptions and logging information</li>

<hr>
<h3>Application architecture</h3>
<p />
<p>Solution view</p>

![image](https://github.com/kadisin/TicketManagement/assets/38622355/69bbdba2-1b92-44fc-923e-579ad625fb59)

<p />
<h3>CQRS - Command Query Resposibility Separation and mediator pattern</h3>
<p>Pattern used to separate query - read and command - add, update, delete operations</p>
<p>Event separation</p>

![image](https://github.com/kadisin/TicketManagement/assets/38622355/f4ebc03f-374d-44ea-baf0-d8f145ff3930)

<p>Requests implement IRequest interface (from MediatR package)</p>

![image](https://github.com/kadisin/TicketManagement/assets/38622355/1cc6ea8f-c52a-4ccc-8dda-9317fdcbc7c2)

<p>Request handlers implements IRequestHandler interface</p>

![image](https://github.com/kadisin/TicketManagement/assets/38622355/665edca1-9769-4643-98dc-828a37e41fc4)

![image](https://github.com/kadisin/TicketManagement/assets/38622355/a5074553-28e2-419f-8497-84d8383602fb)

<p> Controller create request and call it to handler <p>

![image](https://github.com/kadisin/TicketManagement/assets/38622355/53442001-0784-4a7e-b9d2-eabd872bf016)

<p> Validation added if necessary (fluent valdation)<p>

![image](https://github.com/kadisin/TicketManagement/assets/38622355/1a3bc40e-7813-4766-b76a-4e154d04e0bb)

![image](https://github.com/kadisin/TicketManagement/assets/38622355/c49575a2-c634-431d-84c1-8e6e6f156a2e)

<hr>
<h3>Dependecy Injection</h3>
<p />
<p>If needed project have registered services</p>

![image](https://github.com/kadisin/TicketManagement/assets/38622355/22582254-efa7-49a7-8d88-e6645076f886)

<p>Api project manage all registered services</p>

![image](https://github.com/kadisin/TicketManagement/assets/38622355/bcb94b75-3b03-46b7-b431-f014c4967283)


![image](https://github.com/kadisin/TicketManagement/assets/38622355/8b61a4de-7d76-4fec-9832-3dc9ef9d4493)

<hr>
<h3>Exception handling and logging</h3>
<p>Exception is thrown into Exception handler middleware</p>
<p>Plugged into pipeline</p>

![image](https://github.com/kadisin/TicketManagement/assets/38622355/ec595c8a-4d65-4450-b4a8-5a3f76cb4fdb)

![image](https://github.com/kadisin/TicketManagement/assets/38622355/c63b1080-a9f1-4b8f-ba00-87c64a5934f4)

<hr>
<p>Logging important steps in application</p>
<p>Save logs to files</p>

![image](https://github.com/kadisin/TicketManagement/assets/38622355/796ecb72-e244-4007-905a-f2220d968678)

![image](https://github.com/kadisin/TicketManagement/assets/38622355/d8464feb-bb91-42b4-a1ee-3df2eab10a33)

<hr>

</body>
</html>
