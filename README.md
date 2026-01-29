# StatsAPI

POST /api/stats. Tar emot JSON med vilken stad som söktes på samt vilket IP som gjorde requesten, och sparar detta i en databas. GET /api/stats/top som svarar med de 5 mest sökta städerna. GET /api/stats/all som svarar med all statistik.

Req: Lägg till exempel på Json-data

Post "api/stats"

Exempel:

{
  "Name": ""
}

Id sätts automatiskt, IPAddress tas in via HTTPContext, Name är det vi söker på & DateSearched är dagens datum.

--------

Get "api/stats/top"
top 5 städer som sökts

Exempel:

[
  {
    "city": "Borås",
    "searchCount": 8
  },
  {
    "city": "Göteborg",
    "searchCount": 3
  }
]

--------
Get "api/stats/all"
Alla städer som sökts

Exempel:

[
  {
    "id": 1,
    "ipAddress": "127.0.0.1",
    "name": "Borås",
    "dateSearched": "2026-01-29T12:22:47.6644376"
  },
  {
    "id": 2,
    "ipAddress": "127.0.0.1",
    "name": "Borås",
    "dateSearched": "2026-01-29T12:22:52.1145785"
  }
]