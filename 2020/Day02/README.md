original source: [https://adventofcode.com/2020/day/2](https://adventofcode.com/2020/day/2)
## --- Day 2: Password Philosophy ---
Your flight departs in a few days from the coastal airport; the easiest way down to the coast from here is via [toboggan](https://en.wikipedia.org/wiki/Toboggan).

The shopkeeper at the North Pole Toboggan Rental Shop is having a bad day. "Something's wrong with our computers; we can't log in!" You ask if you can take a look.

Their password database seems to be a little corrupted: some of the passwords wouldn't have been allowed by the Official Toboggan Corporate Policy that was in effect when they were chosen.

To try to debug the problem, they have created a list (your puzzle input) of <em>passwords</em> (according to the corrupted database) and <em>the corporate policy when that password was set</em>.

For example, suppose you have the following list:

<pre>
<code>1-3 a: abcde
1-3 b: cdefg
2-9 c: ccccccccc
</code>
</pre>

Each line gives the password policy and then the password. The password policy indicates the lowest and highest number of times a given letter must appear for the password to be valid. For example, <code>1-3 a</code> means that the password must contain <code>a</code> at least <code>1</code> time and at most <code>3</code> times.

In the above example, <code><em>2</em></code> passwords are valid. The middle password, <code>cdefg</code>, is not; it contains no instances of <code>b</code>, but needs at least <code>1</code>. The first and third passwords are valid: they contain one <code>a</code> or nine <code>c</code>, both within the limits of their respective policies.

<em>How many passwords are valid</em> according to their policies?


