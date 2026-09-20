# ProcessField API Documentation

This document outlines the CRUD operations and routing structures available for the `ProcessFields` module.

### Base Route
`http://{host}/api/process-fields`

---

### 1. Create a Process Field
Registers a new form field mapping inside an existing Process Definition.

* **HTTP Verb**: `POST`
* **Route**: `/`
* **Request Object (`CreateProcessFieldRequest`)**:
  * `ProcessDefinitionId` (int, required)
  * `FieldName` (string, required) - Unique identifying name
  * `Label` (string, required) - User-facing label
  * `FieldType` (enum: Text=0, Number=1, Date=2, DateTime=3, Dropdown=4, TextArea=5, Checkbox=6, Email=7, Url=8, Phone=9)
  * `IsRequired` (bool)
  * `SortOrder` (int)
  * `Placeholder` (string, optional)
  * `DefaultValue` (string, optional)
  * `OptionsJson` (string, optional) - JSON string array for dropdown items
  * `MinLength`, `MaxLength` (int, optional)
  * `Min`, `Max` (decimal, optional)
  * `Pattern` (string, optional) - regex pattern
* **Response Object**: `201 Created` returning a `ProcessFieldResponse` detailing the newly assigned Field ID.

---

### 2. Retrieve a Specific Process Field
Fetches detailed configuration schema for a single specific field.

* **HTTP Verb**: `GET`
* **Route**: `/{id}`
* **Response Object**: `200 OK` returning a `ProcessFieldResponse`.

---

### 3. Retrieve All Fields for a Process Definition
Fetches the ordered list of all fields structured beneath a shared Process Definition schema.

* **HTTP Verb**: `GET`
* **Route**: `/process/{processDefinitionId}`
* **Response Object**: `200 OK` returning a `List<ProcessFieldResponse>`.

---

### 4. Update a Process Field
Overwrites the configuration details (e.g. valid ranges, required states, sorting) of an existing Process Field. 

* **HTTP Verb**: `PUT`
* **Route**: `/{id}`
* **Request Object (`UpdateProcessFieldRequest`)**:
  * _Similar to Create process request, but excludes structural immutable constraints like `ProcessDefinitionId` and `FieldName`._
  * Accepts modifications to `Label`, `IsRequired`, `SortOrder`, `Placeholder`, `DefaultValue`, `OptionsJson`, `MinLength/MaxLength`, `Min/Max`, `Pattern`, and `IsActive` state.
* **Response Object**: `200 OK` returning the updated `ProcessFieldResponse`.

---

### 5. Toggle Field Activation Status
Lightweight endpoint dedicated to safely toggling a Process Field actively `on` or `off` without supplying a large payload body.

* **HTTP Verb**: `PATCH`
* **Route**: `/{id}/toggle-status`
* **Response Object**: `200 OK` returning the mutated `ProcessFieldResponse`.

---

### 6. Delete a Process Field
Attempts to completely remove the Process Field from the database.

* **HTTP Verb**: `DELETE`
* **Route**: `/{id}`
* **Safety Constraint**: Fails automatically with `409 Conflict` if existing Application Process Records refer to and leverage this Field's recorded values.
* **Response Object**: `204 No Content` indicating successful deletion.
