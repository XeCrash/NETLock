# NETLock — Usage (focused on NETLock.cs)

This document explains how to use the public-facing flows in NETLock/NETLock.cs and how the example application typically calls into it.

Primary file
- NETLock/NETLock.cs: https://github.com/XeCrash/NETLock/blob/master/NETLock/NETLock.cs

Main flows (what you will call)
1. Program authentication (token)
   - Class: AuthResponse
   - Method: AuthenticateProgram(string token)
   - Typical use: On application startup, call AuthenticateProgram with a token stored in your application (distributed by Admin/Panel). On success Properties.Settings.Default.Authenticated = true.
   - Behavior: calls ProtectionMethods.TamperDetection, then checks token in `authentication` table.

2. User login
   - Class: LoginResponse
   - Method: Login(string username, string password)
   - Typical use: After AuthenticateProgram succeeded, call Login to validate user credentials.
   - Additional checks: free mode, maintenance mode, HWID check, banned check, updates online status on success.

3. User registration
   - Class: RegisterResponse
   - Methods:
     - FreeRegister(string username, string password)
     - PaidRegister(string username, string password, string license)
   - Typical use: Allow new accounts. PaidRegister validates license and marks license redeemed.

4. Auto-update
   - Classes: AutoUpdateResponse + AutoUpdateMethods
   - Methods: CheckForUpdate(string currentVersion), DownloadUpdate(string PathToSaveDownload)
   - Typical use: Example app can check database for new version and download update link.

5. Misc
   - ProgramStatistics.UsersOnline() — returns number of online users.
   - LogoutResponse.LogoutUpdate() — marks the user offline.

How the example application typically wires these together
- Step 1: At app start call AuthResponse.AuthenticateProgram(token).
- Step 2: If Authenticated, allow login/registration features (LoginResponse/RegisterResponse).
- Step 3: After login, call UpdateOnlineStatus to set online status.
- Step 4: Use AutoUpdateResponse to check/download updates if needed.
- The example apps bundle NETLock.dll and use Settings.Default to persist small values (e.g., Authenticated, username).

Important behaviors to be aware of
- TamperDetection: will attempt to detect & kill certain packet/tamper tools and display a MessageBox.
- HWID: RegisterMethods.HWID() reads ProcessorId from Win32_processor — this is used to compare against stored hwid for user accounts.
- IP/Time: Several methods call external services (https://canihazip.com/s) to determine external IP address; these are synchronous WebClient calls and will block if network is slow/unavailable.
- Database failures are generally handled by returning false; exceptions are often swallowed. Many methods call cm.CloseConnection() in catch blocks.

Quick example (pseudo)
- Authenticate program:
  var auth = new NETLock.AuthResponse();
  if (!auth.AuthenticateProgram("MY_TOKEN")) { /* handle not authenticated */ }

- Login:
  var login = new NETLock.LoginResponse();
  if (login.Login("user", "password")) { /* success */ } else { /* login.info contains reason */ }

Where to change the connection string
- ConnectionMethods.conn has a hard-coded connection string:
  "Server=localhost; Uid=root; Pwd=; Database=mass;"
- Move this into config (app.config / appsettings.json) before deploying.

Recommended next steps (developer)
- Move connection string and other runtime values to a config file or environment variables.
- Replace the raw SQL string concatenation with parameterized queries to avoid SQL injection.
- Add logging around critical failure paths (DB errors, tamper detection, mismatches).
- Add unit tests for:
  - Encryption.CheckPassword / HashPassword
  - Login methods for success/failure paths (mock DB)
  - TamperDetection (mock Process.GetProcessesByName)
