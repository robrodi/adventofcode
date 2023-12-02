original source: [https://adventofcode.com/2020/day/4](https://adventofcode.com/2020/day/4)
## --- Day 4: Passport Processing ---
You arrive at the airport only to realize that you grabbed your North Pole Credentials instead of your passport. While these documents are extremely similar, North Pole Credentials aren't issued by a country and therefore aren't actually valid documentation for travel in most of the world.

It seems like you're not the only one having problems, though; a very long line has formed for the automatic passport scanners, and the delay could upset your travel itinerary.

Due to some questionable network security, you realize you might be able to solve both of these problems at the same time.

The automatic passport scanners are slow because they're having trouble <em>detecting which passports have all required fields</em>. The expected fields are as follows:


 - <code>byr</code> (Birth Year)
 - <code>iyr</code> (Issue Year)
 - <code>eyr</code> (Expiration Year)
 - <code>hgt</code> (Height)
 - <code>hcl</code> (Hair Color)
 - <code>ecl</code> (Eye Color)
 - <code>pid</code> (Passport ID)
 - <code>cid</code> (Country ID)

Passport data is validated in batch files (your puzzle input). Each passport is represented as a sequence of <code>key:value</code> pairs separated by spaces or newlines. Passports are separated by blank lines.

Here is an example batch file containing four passports:

<pre>
<code>ecl:gry pid:860033327 eyr:2020 hcl:#fffffd
byr:1937 iyr:2017 cid:147 hgt:183cm

iyr:2013 ecl:amb cid:350 eyr:2023 pid:028048884
hcl:#cfa07d byr:1929

hcl:#ae17e1 iyr:2013
eyr:2024
ecl:brn pid:760753108 byr:1931
hgt:179cm

hcl:#cfa07d eyr:2025 pid:166559648
iyr:2011 ecl:brn hgt:59in
</code>
</pre>

The first passport is <em>valid</em> - all eight fields are present. The second passport is <em>invalid</em> - it is missing <code>hgt</code> (the Height field).

The third passport is interesting; the <em>only missing field</em> is <code>cid</code>, so it looks like data from North Pole Credentials, not a passport at all! Surely, nobody would mind if you made the system temporarily ignore missing <code>cid</code> fields.  Treat this "passport" as <em>valid</em>.

The fourth passport is missing two fields, <code>cid</code> and <code>byr</code>. Missing <code>cid</code> is fine, but missing any other field is not, so this passport is <em>invalid</em>.

According to the above rules, your improved system would report <code><em>2</em></code> valid passports.

Count the number of <em>valid</em> passports - those that have all required fields. Treat <code>cid</code> as optional. <em>In your batch file, how many passports are valid?</em>


