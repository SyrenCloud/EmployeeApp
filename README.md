# Intro

<p>Managing a simple DevOps process is itself a challenge for enterprises, especially when you consider all the moving parts of this process. It could be simple enough for organizations which have simple needs, and it could be as complex with hundreds of moving parts. 
The complexity of moving from a fully manual design, development, and hosting process to an agile, fully cloud-native and automated process can be time consuming, laborious and intensive process even with expert guidance internally. 
This one-time implementation of DevOps into your routines and processes can lead to better idea-to-feature implementation, higher efficiencies and better RoI than your older process.
When you are implementing a DevOps process, either in a greenfield project, or improving your current process, it is essential to build resiliency, avoid cloud lock-in, agility, flexibility, scalability and for performance during this juncture.
When developers have the flexibility to choose the type of cloud, cloud environment, pipeline automation tools and languages to build secure applications which perform as planned while ensuring budgets are not exceeded, they build wonderful applications.
At Syren, we wish to showcase our capabilities in implementing DevOps for applications designed to work in multi-cloud environments, and that too in a wide variety of application architecture styles.
We shall over the next few weeks showcase one application at a time built on a different cloud, a different language and different tools used for DevOps.</p>

# About this code

<p>This is a simple Two-Tier Architecture application developed in .NET Core, a MVC architecture, an SQL server DB as backend with entity framework.
This application is designed to have all CRUD oprations on an Employee Table. </p>

Contains just the following fields
- EmployeeID (EmpID)
- Employee Name (EmpName)
- Email (Email)
- Age (Age)
- Salary (Salary)


# Architecture

Insert architecture diagram here.

# Setup & Requirements

- Visual Studio Code or Microsoft Visual Studio
- SQL Server 

# Running this EmployeeApp

1. Clone the repo
	git clone https://github.com/vinodyvr/EmployeeApp.git
2. Create the DB schema
	Create the database schema with help of <a target="_blank" rel="noopener noreferrer"  href="/EmployeeDB/EmployeeDB.sql">SQL Script file</a>
3. Update SQL connection
	Update the Sql connection string in the "appsettings.Json" in EmployeeApp.Web
4. Run the command to access the application
	Open Terminal in the visual studio code and run below listed commaned

<pre>
	dotnet build // This will build the application 
	
	dotnet run // This command run the application
</pre>

# EmployeeApp Deployment with AZURE DevOps

The following services are required and we are using Azure as an example for the application

1. App Service
2. SQL Server Database. 

<p>We are creating these Service using ARM (Azure Resource Manager) templates in Azure DevOps with CI-CD Pipelines.</p>
<p><a target="_blank" rel="noopener noreferrer" href="/images/armtemplate.PNG"><img src="/images/armtemplate.PNG" alt="ARM Template" style="max-width:100%;"></a></p>

Here's a link to the ARM template
<a href="/ARMTemplates" > ARM Template Project </a>

# Azure DevOps Work Flow

<p><a target="_blank" rel="noopener noreferrer" href="/images/Azure_pipeline_WorkFlow.PNG"><img src="/images/Azure_pipeline_WorkFlow.PNG" alt="Architecture diagram" style="max-width:100%;"></a></p>

# Build Pipeline with CI 

Whenever new code is pushed to the master branch the build pipeline will be triggered 

1. Get the latest code from git master branch.
2. Restore required dependency 
3. Build application
4. Copying the ARM Template files to build folder
   This ARM Template is defined to create the required service in Azure Portal
5. Copying the SQL Script file to build folder
   This Sql Script file contains the database schema for this application
6. Createthe artifact file in Azure DevOps. This will be used to deploy the application in multiple environments.

<p><a target="_blank" rel="noopener noreferrer" href="/images/build_Pipeline.PNG"><img src="/images/build_Pipeline.PNG" alt="Architecture diagram" style="max-width:100%;"></a></p>

# Release Pipeline with CD

<p>This will contains all stages required such as the Dev, QA and Production. Each stage will have jobs and Tasks.</p>

<p><a target="_blank" rel="noopener noreferrer" href="/images/release_pipeline_flow.png"><img src="/images/release_pipeline_flow.png" alt="Architecture diagram" style="max-width:100%;"></a></p>

1. We need to configure all the variables as per environment like (Dev, QA and Prod) 
2. ARM Template Deployment:
   We are creating the Resources (App Service, SQL Server Database) defined in the ARM template
3. Azure App Service Deployment:
   We will deploy the App code from the artifact file in Build pipeline to App Service.
4. Azure SQL Database Deployment:
   We will create all the required database schema for this application
   
<p><a target="_blank" rel="noopener noreferrer" href="/images/release_pipeline.PNG"><img src="/images/release_pipeline.PNG" alt="Architecture diagram" style="max-width:100%;"></a></p>

<p>While this is a simple example of using DevOps on a simple application, we shall at later dates provide examples of using DevOps in much more complex scenarios.<\p>
