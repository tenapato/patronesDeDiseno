# Adapter Pattern design
### Patricio Tena
### A01027293

---
Este proyecto recibe un JSON y lo regresa como xml.
El ejemplo del json a recibir es de la siguiente manera:
```json
{
    "name": "Super Smash Bros.",
    "Genre": "Fighting",
    "publisher": "Nintendo",
    "release_year": 2018,
    "score": 9.5
}
```

Y regresa un XML como el siguiente:
```xml
<Game>
  <Name>Super Smash Bros.</Name>
  <Genre>Fighting</Genre>
  <publisher>Nintendo</publisher>
  <release_year>2018</release_year>
  <score>9.5</score>
</Game>
```

Se puede usar este comando para probarlo:

```
curl --location --request POST -k 'https://localhost:7098/json2xml' \
--header 'Content-Type: application/json' \
--data-raw '{
  "name": "Super Smash Bros.",
  "Genre": "Fighting",
    "publisher": "Nintendo",
    "release_year": 2018,
    "score": 9.5
}'
```