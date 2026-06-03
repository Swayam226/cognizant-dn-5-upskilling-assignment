console.log("Welcome to the Community Portal");

window.onload = function () {
    alert("Page loaded successfully");

    let saved = localStorage.getItem("eventType");

    if (saved) {
        document.getElementById("eventType").value = saved;
    }
};

const eventName = "Tech Meetup";
const eventDate = "2026-12-10";
let seats = 50;

console.log(`${eventName} on ${eventDate} has ${seats} seats available`);

seats--;

console.log(`Seats remaining: ${seats}`);

function validatePhone(input) {
    if (input.value.length < 10) {
        alert("Enter a valid phone number");
    }
}

function showFee() {
    let fee = document.getElementById("eventType").value;

    document.getElementById("fee").innerHTML = "Event Fee: ₹" + fee;
}

function showConfirmation() {
    document.getElementById("outputMessage").value =
        "Registration Submitted Successfully";
}

function enlargeImage(img) {
    img.style.width = "250px";
    img.style.height = "180px";
}

function countCharacters() {
    let count = document.getElementById("feedback").value.length;

    document.getElementById("charCount").innerHTML = "Characters: " + count;
}

function videoReady() {
    document.getElementById("videoMessage").innerHTML = "Video ready to play";
}

function savePreference() {
    let selected = document.getElementById("eventType").value;

    localStorage.setItem("eventType", selected);
    sessionStorage.setItem("eventType", selected);

    alert("Preference Saved");
}


function clearPreferences() {
    localStorage.clear();
    sessionStorage.clear();

    alert("Preferences Cleared");
}

function findLocation() {
    navigator.geolocation.getCurrentPosition(
        function (position) {
            document.getElementById("location").innerHTML =
                "Latitude: " +
                position.coords.latitude +
                "<br>Longitude: " +
                position.coords.longitude;
        },

        function (error) {
            document.getElementById("location").innerHTML =
                "Location access denied or timed out";
        },

        {
            enableHighAccuracy: true,
            timeout: 5000,
        },
    );
}

window.onbeforeunload = function () {
    return "You have unsaved form data.";
};
const events = [
    {
        name: "Tech Meetup",
        date: "2026-12-10",
        seats: 20,
        category: "Technology",
    },
    {
        name: "Food Festival",
        date: "2026-08-10",
        seats: 15,
        category: "Food",
    },
    {
        name: "Music Night",
        date: "2026-11-20",
        seats: 0,
        category: "Music",
    },
    {
        name: "Workshop",
        date: "2026-10-15",
        seats: 30,
        category: "Education",
    },
];
console.log("Available Events:");

events.forEach((event) => {
    let today = new Date();
    let eventDate = new Date(event.date);

    if (eventDate > today && event.seats > 0) {
        console.log(
            `${event.name} | Date: ${event.date} | Seats: ${event.seats}`,
        );
    } else {
        console.log(`${event.name} is not available`);
    }
});
function registerForEvent(eventName) {
    try {
        let selectedEvent = events.find(
            (event) => event.name === eventName,
        );

        if (!selectedEvent) {
            throw new Error("Event not found");
        }

        if (selectedEvent.seats <= 0) {
            throw new Error("No seats available");
        }

        selectedEvent.seats--;

        console.log(
            `Registered for ${selectedEvent.name}. Remaining seats: ${selectedEvent.seats}`,
        );
    } catch (error) {
        console.error(error.message);
    }
}
function addEvent(name, date, seats, category) {
    events.push({
        name,
        date,
        seats,
        category,
    });
}
function registerUser(eventName) {
    registerForEvent(eventName);
}
function registrationTracker(category) {
    let totalRegistrations = 0;

    return function () {
        totalRegistrations++;

        console.log(
            `${category} registrations: ${totalRegistrations}`,
        );
    };
}
function searchEvents(callback) {
    return callback(events);
}
function filterEventsByCategory(category) {
    return events.filter(
        (event) => event.category === category
    );
}
const techRegistrationCounter =
    registrationTracker("Technology");

techRegistrationCounter();
techRegistrationCounter();
techRegistrationCounter();
const filteredEvents = searchEvents((events) =>
    events.filter((event) => event.seats > 10)
);

console.log(filteredEvents);
registerForEvent("Tech Meetup");
registerForEvent("Music Night");
registerForEvent("Random Event");

addEvent(
    "Photography Workshop",
    "2026-12-20",
    25,
    "Education"
);

console.log(filterEventsByCategory("Education"));
class Event {
    constructor(name, date, seats, category) {
        this.name = name;
        this.date = date;
        this.seats = seats;
        this.category = category;
    }
}

Event.prototype.checkAvailability = function () {
    if (this.seats > 0) {
        return `${this.name} has seats available`;
    }

    return `${this.name} is full`;
};

const bakingWorkshop = new Event(
    "Baking Workshop",
    "2026-12-15",
    25,
    "Education"
);

console.log(
    bakingWorkshop.checkAvailability()
);

Object.entries(bakingWorkshop).forEach(
    ([key, value]) => {
        console.log(`${key}: ${value}`);
    }
);
events.push({
    name: "Dance Show",
    date: "2026-11-30",
    seats: 40,
    category: "Music",
});

const musicEvents =
    events.filter(
        (event) =>
            event.category === "Music"
    );

console.log("Music Events:");
console.log(musicEvents);

const formattedEvents =
    events.map(
        (event) =>
            `Workshop on ${event.name}`
    );

console.log(formattedEvents);
const eventContainer =
    document.querySelector(
        "#eventContainer"
    );

function displayEvents(eventsToShow) {

    eventContainer.innerHTML = "";

    eventsToShow.forEach((event) => {

        const card =
            document.createElement("div");

        card.innerHTML = `
      <h3>${event.name}</h3>
      <p>${event.category}</p>
      <p>Seats: ${event.seats}</p>

      <button onclick="registerForEvent('${event.name}')">
        Register
      </button>
    `;

        eventContainer.appendChild(card);
    });
}

displayEvents(events);
const categoryFilter =
    document.querySelector(
        "#categoryFilter"
    );

categoryFilter.onchange =
    function () {

        let selected =
            this.value;

        if (selected === "All") {
            displayEvents(events);
            return;
        }

        const filtered =
            events.filter(
                (event) =>
                    event.category === selected
            );

        displayEvents(filtered);
    };
const searchBox =
    document.querySelector(
        "#searchBox"
    );

searchBox.addEventListener(
    "keydown",
    function () {

        let searchText =
            searchBox.value.toLowerCase();

        const results =
            events.filter(
                (event) =>
                    event.name
                        .toLowerCase()
                        .includes(searchText)
            );

        displayEvents(results);
    }
);
function fetchEvents() {

    console.log(
        "Loading events..."
    );

    fetch(
        "https://jsonplaceholder.typicode.com/posts"
    )
        .then((response) =>
            response.json()
        )
        .then((data) => {

            console.log(
                "Events fetched"
            );

            console.log(data);

        })
        .catch((error) => {

            console.error(error);

        });
}

fetchEvents();
async function fetchEventsAsync() {

    try {

        const response =
            await fetch(
                "https://jsonplaceholder.typicode.com/posts"
            );

        const data =
            await response.json();

        console.log(data);

    } catch (error) {

        console.error(error);

    }
}

fetchEventsAsync();
function createEvent(
    name = "New Event",
    category = "General"
) {
    console.log(
        `${name} belongs to ${category}`
    );
}

createEvent();
createEvent(
    "Coding Bootcamp",
    "Technology"
);
const firstEvent = events[0];

const {
    name,
    date,
    seats,
    category,
} = firstEvent;

console.log(
    name,
    date,
    seats,
    category
);
const copiedEvents =
    [...events];

console.log(
    copiedEvents
);
const registrationForm =
    document.getElementById(
        "registrationForm"
    );

registrationForm.addEventListener(
    "submit",
    function (event) {

        event.preventDefault();

        const name =
            registrationForm.elements[0].value;

        const email =
            registrationForm.elements[1].value;

        if (
            name === "" ||
            email === ""
        ) {

            document.getElementById(
                "formError"
            ).innerText =
                "Please fill all fields";

            return;
        }

        document.getElementById(
            "formError"
        ).innerText =
            "Form submitted successfully";
    }
);
function submitRegistration() {

    const userData = {
        name: "John",
        email: "john@test.com",
    };

    setTimeout(() => {

        fetch(
            "https://jsonplaceholder.typicode.com/posts",
            {
                method: "POST",

                headers: {
                    "Content-Type":
                        "application/json",
                },

                body:
                    JSON.stringify(
                        userData
                    ),
            }
        )
            .then((response) =>
                response.json()
            )
            .then((data) => {

                console.log(
                    "Registration Successful"
                );

                console.log(data);

            })
            .catch((error) => {

                console.log(
                    "Registration Failed"
                );

            });

    }, 2000);
}

submitRegistration();
$("#registerBtn").click(
    function () {
        $("#eventContainer")
            .fadeOut(1000)
            .fadeIn(1000);
    }
);
console.log(
    "React and Vue help build reusable UI components and manage state more efficiently."
);