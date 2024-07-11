# Football Player and Team Management API

## Description
The Football Player and Team Management API allows users to manage their collection of football players and teams. This API enables CRUD operations on players and teams, with a relationship between the two entities.

## Instructions
### Running the API
1. Ensure you have the .NET SDK installed.
2. Clone the repository.
3. Open the project in your preferred IDE.
4. Run the project using the command `dotnet run`.

### Testing the API
Use a tool like Postman or Swagger to test the API endpoints.

### API Endpoints
#### Player Endpoints
- `GET /api/player`: Get all players.
- `GET /api/player/{id}`: Get a player by ID.
- `POST /api/player`: Create a new player.
- `PUT /api/player/{id}`: Update an existing player.
- `DELETE /api/player/{id}`: Delete a player.

#### Team Endpoints
- `GET /api/team`: Get all teams.
- `GET /api/team/{id}`: Get a team by ID.
- `POST /api/team`: Create a new team.
- `PUT /api/team/{id}`: Update an existing team.
- `DELETE /api/team/{id}`: Delete a team.

### Examples
#### Get All Players
```bash
curl -X GET "https://localhost:5001/api/player" -H "accept: text/plain"
