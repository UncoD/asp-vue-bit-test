# Bit test task

Allows to calculate the angle of vertical tilt of the camera, depending on the height of its location and the distance to the person.

The calculation results are saved in the database.

## Setup

### ClientApp
Requires [Node.js](https://nodejs.org/) v14

In the ClientApp folder run:

    npm install

### Database
Used [MariaDB](https://mariadb.org/download/) (v10.5.9)

The connection string is in `appsettings.json`

In the Package Manager Console run:

    update-database