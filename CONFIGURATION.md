# NETLock — Configuration and Database Schema

This file documents configuration values and the database tables/columns required by NETLock/NETLock.cs.

Configuration (in-source defaults)
- Connection string (ConnectionMethods):
  - Default in code: "Server=localhost; Uid=root; Pwd=; Database=mass;"
  - Recommendation: move to app.config/appsettings.json or environment variables.

- External IP lookup URL:
  - https://canihazip.com/s
  - Recommendation: replace with a stable internal endpoint or make it optional.

- Settings used:
  - Properties.Settings.Default.Authenticated — set to true when program token authenticates.
  - Properties.Settings.Default.username — set after successful login.

Database schema (minimum fields observed)
1. authentication
   - token (string)

2. users
   - uid (string)             — username / unique id
   - pwd (string)             — hashed password (BCrypt-style)
   - registered (string)      — timestamp
   - lastlogin (string)       — timestamp
   - online (string)          — 'true' / 'false'
   - isbanned (string)        — 'true' / 'false'
   - hwid (string)            — stored hardware ID
   - ipaddr (string)          — registration IP
   - lastloggedipaddr (string)

3. licenses
   - license (string)         — license code
   - isredeemed (string)      — 'true' / 'false'
   - uid (string)             — assigned username after redeem

4. administration
   - maintenancemode (string) — 'true' / 'false'
   - freemode (string)        — 'true' / 'false'
   - hwidcheckenabled (string)— 'true' / 'false'
   - appversion (string)      — current application version
   - downloadlink (string)    — URL to current release

Important notes on schema usage
- Many queries use string equality comparisons such as `WHERE online='true'` and read values via reader.GetString(0). Normalize data types as booleans where possible and use a consistent date format (UTC ISO 8601).
- The current code assumes single-row administration table (SELECT ... FROM administration). Make sure administration has a single row or adjust queries.

Suggested sample SQL (very basic)
- users table (simplified):
  CREATE TABLE users (
    uid VARCHAR(255) PRIMARY KEY,
    pwd TEXT NOT NULL,
    registered DATETIME,
    lastlogin DATETIME,
    online TINYINT(1) DEFAULT 0,
    isbanned TINYINT(1) DEFAULT 0,
    hwid VARCHAR(255),
    ipaddr VARCHAR(45),
    lastloggedipaddr VARCHAR(45)
  );

- licenses table:
  CREATE TABLE licenses (
    license VARCHAR(255) PRIMARY KEY,
    isredeemed TINYINT(1) DEFAULT 0,
    uid VARCHAR(255)
  );

- administration table (single row):
  CREATE TABLE administration (
    id INT PRIMARY KEY,
    maintenancemode TINYINT(1),
    freemode TINYINT(1),
    hwidcheckenabled TINYINT(1),
    appversion VARCHAR(50),
    downloadlink TEXT
  );

Security & hardening (configuration)
- Use a DB account with least privilege and a strong password; do not keep DB root credentials in code.
- Prefer SSL/TLS for DB connections and any update/download endpoints.
- Replace raw SQL concatenation with parameterized queries (MySqlParameter).
- Rate-limit or protect endpoints used for token verification and license redemption.
