/*namespace ProjectVs
{
    public class login
    {
    }
}

const form = document.getElementById('registration-form');
const loginForm = document.getElementById("login-form");
const passwordInput = document.getElementById('password');
const confirmPasswordInput = document.getElementById('confirm-password');

// Establish a connection to the SQL database
const mysql = require('mysql');
const connection = mysql.createConnection({
    host: 'User',
    user: 'DESKTOP-MOOICF1\User',
    password:
        database: 'register'
});

connection.connect((err) => {
    if (err) {
        console.error('Error connecting to database: ' + err.stack);
        return;
    }
    console.log('Connected to database.');
});

// Login
app.post('/login', (req, res) => {
    const username = req.body.username;
    const password = req.body.password;

    connection.query('SELECT * FROM users WHERE username = ? AND password = ?', [username, password], (err, results) => {
        if (err) {
            console.log(err);
            res.send('error');
        } else if (results.length > 0) {
            res.send('success');
        } else {
            res.send('failure');
        }
    });
});

// Login Form Validation
/*if (loginForm) {
    loginForm.addEventListener("submit", async (event) => {
        event.preventDefault();
        const username = document.getElementById("username").value;
        const password = document.getElementById("password").value;
        const errorField = document.getElementById("error");

        if (!username || !password) {
            errorField.innerHTML = "All fields are required.";
            return;
        }

        const user = {
            username: username,
            password: password,
        };

        const response = await fetch("/login", {
            method: "POST",
            headers: {
                "Content-Type": "application/json",
            },
            body: JSON.stringify(user),
        });

        const result = await response.json();

        if (result.error) {
            errorField.innerHTML = result.error;
        } else {
            errorField.innerHTML = "Login successful.";
            loginForm.reset();
            setTimeout(() => {
                window.location.href = "./index.html"; // Redirect to homepage after 2 seconds
            }, 2000);
        }
    });
}

protected void btnLogin_Click(object sender, EventArgs e)
{
    // Get the input values from the login form
    string username = txtUsername.Text.Trim();
    string password = txtPassword.Text;

    // Validate the input values
    string error = ValidateLoginForm(username, password);
    if (!string.IsNullOrEmpty(error)) {
        lblError.Text = error;
        return;
    }

    // Wait for 2 seconds (optional)
    System.Threading.Thread.Sleep(2000);

    // Check if the user exists in the database
    User user = GetUserByUsername(username);
    if (user == null || !user.Password.Equals(password)) {
        lblError.Text = "Invalid username or password.";
        return;
    }

    // Save the user data to the session
    Session["User"] = user;

    // Redirect to the homepage
    Response.Redirect("~/Homepage.aspx");
}

document.getElementById("login-form").addEventListener("submit", async (event) => {
    event.preventDefault();

    const username = document.getElementById("username").value;
    const password = document.getElementById("password").value;

    try {
        const response = await fetch("/api/login", {
            method: "POST",
            headers: {
                "Content-Type": "application/json"
            },
            body: JSON.stringify({ username, password })
        });

        if (response.ok) {
            // Login successful
            alert("Login successful!");

            // Redirect to index.html after 5 seconds
            setTimeout(() => {
                window.location.href = "./index.html";
            }, 5000);
        } else {
            // Login failed
            const errorData = await response.json();
            alert(errorData.message);
        }
    } catch (error) {
        console.error(error);
        alert("An error occurred during login.");
    }
});*/