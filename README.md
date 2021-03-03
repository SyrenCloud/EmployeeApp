# EmployeeApp
<p>This is a Two-Tier Architecture application developed in dot net Core MVC and SQL server DB as backend with entity frame work.</p>
<p>This application developed for all CRUD oprations on Employee Table. Contains below feilds </p>
<ul>
	<li>EmpId</li>
	<li>EmpName</li>
	<li>Email</li>
	<li>Age</li>
	<li>Salary</li>
</ul>

# Architecture

<p><a target="_blank" rel="noopener noreferrer" href="/images/appframework.PNG"><img src="/images/appframework.PNG" alt="Architecture diagram" style="max-width:100%;"></a></p>

# Setup  

Visual Studio Code or Microsoft Visual Studio

SQL Server 

# Running this EmployeeApp

1. git clone https://github.com/vinodyvr/EmployeeApp.git
2. Create the database schema with help of <a target="_blank" rel="noopener noreferrer"  href="/EmployeeDB/EmployeeDB.sql">SQL Script file</a>
3. Update the Sql connection string in the "appsettings.Json" in EmployeeApp.Web
4. Open Terminal in the visual studio code and runn below listed commaned

<pre>
	dotnet build // This will build the application 
	
	dotnet run // This command run the application
</pre>

# EmployeeApp Deployment with AZURE DevOps

Required Services on Azure portal are listed below

1. App Service

2. SQL Server Database. 

We are creating these Service using ARM (Azure Resource Manager) templates in Azure DevOps with CI-CD Pipelines.
ARM Template Project Link <a href="/ARMTemplates" > ARM Template Project </a>

# Azure DevOps Work Flow

<p><a target="_blank" rel="noopener noreferrer" href="/images/Azure_pipeline_WorkFlow.PNG"><img src="/images/Azure_pipeline_WorkFlow.PNG" alt="Architecture diagram" style="max-width:100%;"></a></p>

# Build Pipeline with CI 

Whenever new code push to master branch this will be triggered 

1. Get latest code from git master branch.
2. Restore Required dependency 
3. Build the application
4. Copying the ARM Template files to build folder
   This ARM Template define to create the required service in Azure Portal
5. Copying the SQL Script file to build folder
   This Sql Script file contains the database Schema for this application
6. Crating Artifact file in Azure DevOps. This we will use for Deploy application in different Environments.

<p><a target="_blank" rel="noopener noreferrer" href="/images/build_Pipeline.PNG"><img src="/images/build_Pipeline.PNG" alt="Architecture diagram" style="max-width:100%;"></a></p>

# Release Pipeline with CD

This will contains Stages Like Dev, QA , Prod. Each stage will have jobs and Tasks.
<p><a target="_blank" rel="noopener noreferrer" href="/images/release_pipeline_flow.png"><img src="/images/release_pipeline_flow.png" alt="Architecture diagram" style="max-width:100%;"></a></p>

1. We need to configure all the variables as per environment like (Dev, QA and Prod) 
2. ARM Template Deployment:
   We are creating the Resources (App Service, SQL Server Database) define in the ARM template will be created.
3. Azure App Service Deployment:
   We will deploy the App code from the artifact file in Build pipeline to App Service.
4. Azure SQL Database Deployment:
   We will create all the required database schema for this application
   
<p><a target="_blank" rel="noopener noreferrer" href="/images/release_pipeline.PNG"><img src="/images/release_pipeline.PNG" alt="Architecture diagram" style="max-width:100%;"></a></p>
