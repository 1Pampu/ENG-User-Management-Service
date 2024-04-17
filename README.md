
# Index
* [General Information](#general-information)
* [Installation](#installation)
    * [Requirements](#requirements)
    * [Setting Up](#setting-up)
* [API Routes](#api-routes)
    * [Routes](#routes)
        * [Get User Info](#get-user-info)
        * [Get Active Users](#get-active-users)
        * [Create User](#create-user)
        * [Modify User Active Status](#modify-user-active-status)
        * [Delete User](#delete-user)
     
# General Information

This is a repository for a technical test for ENG Company. It comprises a simple API for user management, connected to a MySQL database hosted on alwaysdata. The credentials for accessing the database are as follows:

MySQL User: 355978

Password: naIMrATIShor

Therefore, there's no need to create a local database as it's already provisioned with test data.

Access phpMyAdmin [here](https://phpmyadmin.alwaysdata.com/).
# Installation
## Requirements
.Net SDK 8 is needed to run this App, you can download it from [here](https://dotnet.microsoft.com/es-es/download).
## Setting Up
1. **Clone the repository**: Open a terminal and run the following command to clone this repository to your local machine:
`git clone https://github.com/1Pampu/ENG-User-Management-Service.git`

2. **Open the repository**: Navigate to the newly cloned ENG - User Management Service folder located in the repository:
`cd "ENG - User Management Service/ENG - User Management Service"`

3. **Run the application**: Once you are inside the project folder, run the following command to start the application:
`dotnet run`

This will build and run the application. Once the application is running, you can access it in the URL http://localhost:5180.
# API Routes

## Routes

 | Method |  URL                                       | Description                                                   |
 | :----: | ------------------------------------------ | ------------------------------------------------------------- |
 | **`GET`**  | [`/api/users/{user_id}` ](#get-user-info)    | Get User Info             |
 | **`GET`**  | [`/api/users`](#get-active-users)       | Get Active Users          |
 | **`POST`** | [`/api/users`](#create-user)          | Create User               |
 | **`PUT`** | [`/api/users/{user_id}`](#modify-user-active-status) | Modify User Active Status |
 | **`DELETE`** | [`/api/users/{user_id}`](#delete-user) | Delete User |

### Get User Info

Example Response:

    {
        "id": 1,
        "name": "Martín Piampiani",
        "birthDay": "2003-03-06T00:00:00",
        "active": true
    }

### Get Active Users

Example Response:


    [
        {
            "id": 1,
            "name": "Martín Piampiani",
            "birthDay": "2003-03-06T00:00:00",
            "active": true
        },
        {
            "id": 2,
            "name": "Juan Perez",
            "birthDate": "2000-01-05T00:00:00",
            "active": true
        },
    ]

### Create User
Parameters Expected:
|Parameters|Type|
|----------|:--:|
|**`name`**    |str |
|**`birthDay`**|date |
|**`active`**  |bool |

Note that 'active' is an **OPTIONAL** parameter, it is not necessary to include it if not needed. By default, if not specified, it will start as true.

Example:

    {
        "name": "Martín Piampiani",
        "birthDay": "2003-03-06",
    }

 Example response:

    {
        "id": 1,
        "name": "Martín Piampiani",
        "birthDay": "2003-03-06T00:00:00",
        "active": true
    }

### Modify User Active Status
 Parameters expected:
|Parameters|Type|
|----------|:--:|
|**`active`**    |bool |

Example:

    {
        "active": false
    }

 Example response:

    {
        "id": 1,
        "name": "Martín Piampiani",
        "birthDay": "2003-03-06T00:00:00",
        "active": false
    }

### Delete User

Example Response: **204 No Content**
## 🔗 Links
[![portfolio](https://img.shields.io/badge/my_portfolio-000?style=for-the-badge&logo=ko-fi&logoColor=white)](https://1pampu.github.io/my-portfolio/)
[![linkedin](https://img.shields.io/badge/linkedin-0A66C2?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/martin-piampiani/)
