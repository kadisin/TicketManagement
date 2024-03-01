<p>Backend api application using .NET, Entity Framework, Dependency Injection, CQRS Pattern</p>
Dependency injection, architecture app, cqrs, entity framework, logging, authentication using token,
<p>Readme will be add...</p>

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
<li>Logging</li>
    
<hr>
<h3>Project Information</h3>
<li></li>
<hr>
    
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

<p> Validation added if necessary <p>

![image](https://github.com/kadisin/TicketManagement/assets/38622355/1a3bc40e-7813-4766-b76a-4e154d04e0bb)

![image](https://github.com/kadisin/TicketManagement/assets/38622355/c49575a2-c634-431d-84c1-8e6e6f156a2e)


<p>Scalable application using CQRS and mediator (MediatR) patterns</p>
</body>
</html>
