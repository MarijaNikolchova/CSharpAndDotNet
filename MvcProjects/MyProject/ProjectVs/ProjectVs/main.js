﻿const form = document.getElementById('registration-form');
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


// Registration
app.post('/register', (req, res) => {
    const username = req.body.username;
    const email = req.body.email;
    const password = req.body.password;

    connection.query('SELECT * FROM users WHERE username = ?', [username], (err, results) => {
        if (err) {
            console.log(err);
            res.send('error');
        } else if (results.length > 0) {
            res.send('existing_user');
        } else {
            connection.query('INSERT INTO users (username, email, password) VALUES (?, ?, ?)', [username, email, password], (err, results) => {
                if (err) {
                    console.log(err);
                    res.send('error');
                } else {
                    res.send('success');
                }
            });
        }
    });
});

form.addEventListener('submit', (event) => {
    event.preventDefault();
    const username = form.elements['username'].value;
    const email = form.elements['email'].value;
    const password = passwordInput.value;
    const confirmPassword = confirmPasswordInput.value;

    if (!validatePassword(password)) {
        displayErrorMessage('Password must be at least 8 characters and contain at least 1 number');
        return;
    }

    if (password !== confirmPassword) {
        displayErrorMessage('Passwords do not match');
        return;
    }

    // Sending registration data to server 

    console.log(`Username: ${username}, Email: ${email}, Password: ${password}`);
});

function validatePassword(password) {
    const passwordRegex = /^(?=.*\d).{8,}$/;
    return passwordRegex.test(password);
}

function displayErrorMessage(message) {
    const errorMessageElement = document.createElement('div');
    errorMessageElement.classList.add('error-message');
    errorMessageElement.textContent = message;
    form.appendChild(errorMessageElement);
}

document.getElementById("Login").style.display = "block";

// Registration Form Validation
if (registrationForm) {
    registrationForm.addEventListener("submit", async (event) => {
        event.preventDefault();
        const username = document.getElementById("username").value;
        const email = document.getElementById("email").value;
        const password = document.getElementById("password").value;
        const confirmPassword = document.getElementById("confirm-password").value;
        const errorField = document.getElementById("error");

        if (!username || !email || !password || !confirmPassword) {
            errorField.innerHTML = "All fields are required.";
            return;
        }

        if (password !== confirmPassword) {
            errorField.innerHTML = "Passwords do not match.";
            return;
        }

        const user = {
            username: username,
            email: email,
            password: password,
        };

        const response = await fetch("/register", {
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
            errorField.innerHTML = "User registered successfully.";
            registrationForm.reset();
            setTimeout(() => {
                window.location.href = "/"; // Redirect to homepage after 2 seconds
            }, 2000);
        }
    });
}


//Form submissions
const forgotForm = document

function submitContent() {
    var title = document.getElementById("title").value;
    var text = document.getElementById("text").value;
    var error = document.getElementById("error");

    if (title === "" && text === "") {
        error.innerHTML = "Error: Title and text are required.";
    } else if (title === "") {
        error.innerHTML = "Error: Title is missing.";
    } else if (text === "") {
        error.innerHTML = "Error: Text is required.";
    } else if (text.length > 100000) {
        error.innerHTML = "Error: Text exceeds character limit of 100,000.";
    } else {
        // Submit the form
        alert("Title: " + title + "\nText: " + text);
        document.getElementById("title").value = "";
        document.getElementById("text").value = "";
        error.innerHTML = "";
    }
}