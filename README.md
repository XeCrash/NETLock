# NETLock

NETLock is a C# library and example application providing user authentication, registration, licensing, auto-update, and light tamper-detection logic. The primary implementation lives in NETLock/NETLock.cs — this file contains the core classes and methods used by example applications.

Key points
- Primary file: NETLock/NETLock.cs (see: https://github.com/XeCrash/NETLock/blob/master/NETLock/NETLock.cs)
- Language: C#
- Purpose: authentication (token + username/password), user registration (free and paid), license redemption, auto-update helpers, program statistics, and basic tamper-detection.
- Designed for use with a MySQL backend (MySql.Data).

Status
- Early project; functional and pragmatic.
- Contains logic that should be hardened before production (e.g., SQL concatenation, exception handling, client-side enforcement).
- Contains example solution and example application folders in the repo.

What’s in NETLock.cs (high level)
- Response/flow classes:
  - LoginResponse — user login flow and conditions (maintenance, freemode, HWID check, banned check).
  - AuthResponse — token-based program authentication and free-mode flow.
  - RegisterResponse — user registration (free & paid).
  - ProgramStatistics, LogoutResponse, AutoUpdateResponse — supporting flows.
- Methods for DB access and business logic:
  - ConnectionMethods — opens/closes MySQL connection (connection string included in code).
  - AuthMethods, LoginMethods, RegisterMethods, AutoUpdateMethods — database-driven logic used by the response classes.
- ProtectionMethods — lightweight tamper-detection (kills known packet/tampering processes then shows MessageBox).
- Encryption — built-in BCrypt-style hashing utilities (HashPassword, GenerateSalt, CheckPassword).

Why this file matters
NETLock.cs is the core of this project; example applications rely on its classes and behavior. Because it contains authentication, license and update logic, it is the primary file to review and harden before deploying any real user-facing system.
