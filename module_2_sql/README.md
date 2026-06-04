# ANSI SQL Using MySQL Exercises

## Structure

```
mysql/
├── 01-schema/              CREATE TABLE statements for all 6 tables
├── 02-sample-data/         INSERT statements for the provided sample dataset
├── 03-basic-queries/       Exercises: 1, 3, 4, 6, 7, 8, 11, 16
├── 04-joins-and-aggregates/ Exercises: 2, 5, 9, 12, 13, 14, 17, 18, 19
├── 05-advanced-queries/    Exercises: 10, 15, 20, 21, 22, 23, 24, 25
├── 06-analytics/           All 25 exercises in a single annotated file
└── README.md
```

## Setup

```bash
mysql -u root -p your_database < 01-schema/create_tables.sql
mysql -u root -p your_database < 02-sample-data/insert_data.sql
```

## Exercises

| # | Title |
|---|-------|
| 1 | User Upcoming Events |
| 2 | Top Rated Events |
| 3 | Inactive Users |
| 4 | Peak Session Hours |
| 5 | Most Active Cities |
| 6 | Event Resource Summary |
| 7 | Low Feedback Alerts |
| 8 | Sessions per Upcoming Event |
| 9 | Organizer Event Summary |
| 10 | Feedback Gap |
| 11 | Daily New User Count |
| 12 | Event with Maximum Sessions |
| 13 | Average Rating per City |
| 14 | Most Registered Events |
| 15 | Event Session Time Conflict |
| 16 | Unregistered Active Users |
| 17 | Multi-Session Speakers |
| 18 | Resource Availability Check |
| 19 | Completed Events with Feedback Summary |
| 20 | User Engagement Index |
| 21 | Top Feedback Providers |
| 22 | Duplicate Registrations Check |
| 23 | Registration Trends |
| 24 | Average Session Duration per Event |
| 25 | Events Without Sessions |
