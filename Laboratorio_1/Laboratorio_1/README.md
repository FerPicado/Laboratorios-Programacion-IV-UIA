# **Matricula Management API**

This project is a RESTful API for managing student enrollments (matriculas). It provides endpoints to retrieve, create, and manage enrollment data.

---

## **Features**
- Retrieve a single matricula with predefined values.
- Fetch all matriculas stored in the database.
- Add new matriculas via HTTP POST requests using JSON payloads.

---

## **Technologies Used**
- **ASP.NET Core**: Framework for building the API.
- **Entity Framework Core**: ORM for database interactions.
- **SQL Server**: Database for storing matricula data.
- **Postman**: Tool for testing API endpoints.

---

## **Endpoints**
### **1. Get Matricula**
- **URL**: `/api/Matricula/GetMatricula`
- **Method**: `GET`
- **Description**: Retrieves a sample matricula with hardcoded values.
- **Response**:
  ```json
  {
    "fechaMatricula": "2024-11-20T12:00:00",
    "cupoDisponible": true,
    "estadoMatricula": "Activo",
    "idMatricula": 1,
    "idEstudiante": 1
  }

### **2. Get All Matriculas from Database**
- **URL**: `/api/Matricula/miMatriculaDb`
- **Method**: `GET`
- **Description**: Fetches all matriculas stored in the database.
- **Response Example**:
  ```json
  [
    {
      "fechaMatricula": "2024-11-19T12:00:00",
      "cupoDisponible": true,
      "estadoMatricula": "Activo",
      "idMatricula": 2,
      "idEstudiante": 101
    }
  ]

### **3. Add New Matricula**
- **URL**: `/api/Matricula/nuevaMatricula`
- **Method**: `POST`
- **Description**: Accepts JSON payload to create a new matricula.
- **Request Body Example**:
  ```json
  {
    "fechaMatricula": "2024-11-21T09:30:00",
    "cupoDisponible": true,
    "estadoMatricula": "Pendiente",
    "idMatricula": 3,
    "idEstudiante": 105
  }
  
- **Response**:
  ```json
  {
    "Cupo Disponible": true,
    "Fecha de Matrícula": "2024-11-21T09:30:00",
    "Estado de Matrícula": "Pendiente",
    "ID Estudiante": 105,
    "ID Matrícula": 3
  }

## **Setup Instructions**

### **1. Prerequisites**
- .NET 6 SDK or later installed.
- SQL Server instance configured.
- Postman or similar tool for API testing.


### **2. Configure the Database**
- Update the connection string in `appsettings.json`:
  ```json
  {
    "ConnectionStrings": {
      "DefaultConnection": "Server=YOUR_SERVER;Database=YOUR_DATABASE;Trusted_Connection=True;"
    }
  }

## **Testing the API**
- Use Postman or any HTTP client to test the endpoints. Make sure to:
  - Set the Content-Type to `application/json` for POST requests.
  - Provide valid JSON payloads where required.

## **Future Improvements**
- Add validation for incoming data.
- Implement error logging.
- Include PUT and DELETE endpoints for updating and deleting matriculas.
- Add Swagger documentation for better API usability.
