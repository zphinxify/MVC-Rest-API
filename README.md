# MVC-Rest-API .NET Core 3.1
This is a MVC-Rest-API using Data Transfer Objects and the repository pattern in order to illustrate how data can be sent within the API without exposing the actual object being sent. This is achieved by using dependcy injection and AutoMapper.

AutoMapper is used in order to map the DTO with the actual Object

As for the DB I'm using a SQL server. Note that the password is directly exposed in the source code without any hashing or salt. This is not inteded for use in a production environment.
