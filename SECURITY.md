# NETLock — Security notes (NETLock.cs focused)

NETLock/NETLock.cs contains authentication, registration, license redemption, update, and some tamper-detection logic. This document lists the highest-priority security issues and recommended mitigations.

High-priority issues and fixes
1. SQL injection risk
   - Problem: Almost every DB query is built via string interpolation (e.g., $"SELECT pwd FROM users WHERE uid='{username}'").
   - Risk: a malicious username or license string could change query behavior.
   - Fix: use parameterized queries (MySqlCommand with Parameters) everywhere.

2. Hard-coded connection string and credentials
   - Problem: Connection string is embedded in source with default values (root user, empty password).
   - Fix: move connection string to secure configuration (app.config/appsettings.json) or environment variables. Use a DB user with restricted privileges and a strong password.

3. Error handling and logging
   - Problem: Exceptions are swallowed and methods often return false silently.
   - Fix: add structured logging with enough context to debug (and to audit suspicious behavior). Avoid exposing sensitive data in logs.

4. Client-side enforcement weaknesses
   - Problem: Authorization/enforcement is done on the client side with local checks (e.g., HWID, tamper detection).
   - Risk: client-side checks are bypassable by motivated attackers.
   - Fix: perform critical checks server-side (token validation, license redemption). Use short-lived tokens or signed responses.

5. TamperDetection approach
   - Problem: kills processes by name, shows MessageBox. This behavior can be dangerous (killing unrelated processes), runs with the user's privileges, and can be trivially bypassed.
   - Fix: remove aggressive process-killing. Instead, detect and report suspicious environment, log it, and rely on server-side protections.

6. External network calls
   - Problem: WebClient calls to fetch external IP (canihazip) are synchronous and unverified.
   - Fix: make external calls asynchronous, add timeouts, and validate the response source. Allow fallback/disabled mode.

7. Password storage and BCrypt implementation
   - The code includes BCrypt-style hashing (Encryption class). Ensure that:
     - a strong default cost is used,
     - salts are random and stored with the hashed password (as current format appears to do).
   - Consider using a well-tested library (e.g., BCrypt.Net) rather than custom ported code when possible.

Other recommendations
- Add TLS for downloads and any server communication (use HTTPS and validate certs).
- Add rate-limiting and suspicious activity detection server-side.
- Add unit tests for Authentication and Registration flows (including negative cases).
- Consider threat model:
  - If you want licensing protection, use server-side license checks and signed tokens rather than client-only hashes.

Responsible disclosure
- If someone finds a security issue in this codebase, please open a private GitHub issue or contact the repo owner. Provide reproduction steps, environment, and suggested mitigation.
- 
