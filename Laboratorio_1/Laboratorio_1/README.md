# **Enrollment Management API**

This project is a RESTful API for managing student enrollments. It provides endpoints to retrieve, create, and manage enrollment data.

---

## **Features**
- Retrieve a single enrollment with predefined values.
- Fetch all enrollments stored in the database.
- Add new enrollments via HTTP POST requests using JSON payloads.

---

## **Technologies Used**
- **ASP.NET Core**: Framework for building the API.
- **Entity Framework Core**: ORM for database interactions.
- **SQL Server**: Database for storing enrollment data.
- **Postman**: Tool for testing API endpoints.

---

## **Endpoints**
### **1. Get Enrollment**
- **URL**: `/api/Enrollment/GetEnrollment`
- **Method**: `GET`
- **Description**: Retrieves a sample enrollment with predefined hardcoded values.
- **Response**:
  ```json
  {
    "enrollmentDate": "2024-11-20T12:00:00",
    "isSlotAvailable": true,
    "enrollmentStatus": "Active",
    "enrollmentId": 1,
    "studentId": 2
  }

### **2. Get All Enrollments from Database**
- **URL**: `/api/Enrollment/GetEnrollmentDb`
- **Method**: `GET`
- **Description**: Fetches all enrollments stored in the database.
- **Response Example**:
  ```json
  [
    {
      "enrollmentDate": "2024-11-20T12:00:00",
      "isSlotAvailable": true,
      "enrollmentStatus": "Active",
      "enrollmentId": 1,
      "studentId": 1
    }
  ]

### **3. Add New Enrollment**
- **URL**: `/api/Enrollment/CreateEnrollment`
- **Method**: `POST`
- **Description**: Accepts JSON payload to create a new enrollment.
- **Request Body Example**:
  ```json
  {
    "enrollmentDate": "2024-11-21T09:30:00",
    "isSlotAvailable": true,
    "enrollmentStatus": "Pending",
    "enrollmentId": 3,
    "studentId": 105
  }
  
- **Response**:
  ```json
  {
  "message": "Enrollment 3 created successfully.",
  "enrollmentDetails": {
    "isSlotAvailable": true,
    "enrollmentDate": "2024-11-20T12:00:00",
    "enrollmentStatus": "Active",
    "studentId": 3,
    "enrollmentId": 3
  }
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
      "DefaultConnection": "Server=YOUR_SERVER;Database=YOUR_DATABASE; user=YOUR_USER; password=YOUR_PASSWORD;Trusted_Connection=True;"
    }
  }

## **Testing the API**
- Use Postman or any HTTP client to test the endpoints. Make sure to:
  - Set the Content-Type to `application/json` for POST requests.
  - Provide valid JSON payloads where required.

## **Future Improvements**
- Add validation for incoming data.
- Implement error logging.
- Include PUT and DELETE endpoints for updating and deleting enrollments.
- Add Swagger documentation for better API usability.
