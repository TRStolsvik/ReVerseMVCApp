(function (app) {
    'use strict';

    app.reVerse = function () {
        const submitButton = document.getElementById('btnSubmit');
        submitButton.addEventListener('click', captureString);
    };

    // Capture string from user input
    function captureString() {
        // Capture and store user string
        const userString = document.getElementById('inputString').value;
        document.getElementById('inputString').value = '';

        const revString = reverseString(userString);

        displayString(revString);
    }

    // Reverse string
    function reverseString(userString) {
        let revString = '';

        for (let i = userString.length - 1; i >= 0; i--) {
            revString += userString[i];
        }

        return revString;
    }

    // Display reversed string on the page
    function displayString(revString) {
        document.getElementById('results').innerHTML = revString;
    }
})((window.app = window.app || {}));
