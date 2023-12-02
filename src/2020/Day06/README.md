original source: [https://adventofcode.com/2020/day/6](https://adventofcode.com/2020/day/6)
## --- Day 6: Custom Customs ---
As your flight approaches the regional airport where you'll switch to a much larger plane, [customs declaration forms](https://en.wikipedia.org/wiki/Customs_declaration) are distributed to the passengers.

The form asks a series of 26 yes-or-no questions marked <code>a</code> through <code>z</code>. All you need to do is identify the questions for which <em>anyone in your group</em> answers "yes". Since your group is just you, this doesn't take very long.

However, the person sitting next to you seems to be experiencing a language barrier and asks if you can help. For each of the people in their group, you write down the questions for which they answer "yes", one per line.  For example:

<pre>
<code>abcx
abcy
abcz
</code>
</pre>

In this group, there are <em><code>6</code></em> questions to which anyone answered "yes": <code>a</code>, <code>b</code>, <code>c</code>, <code>x</code>, <code>y</code>, and <code>z</code>. (Duplicate answers to the same question don't count extra; each question counts at most once.)

Another group asks for your help, then another, and eventually you've collected answers from every group on the plane (your puzzle input). Each group's answers are separated by a blank line, and within each group, each person's answers are on a single line. For example:

<pre>
<code>abc

a
b
c

ab
ac

a
a
a
a

b
</code>
</pre>

This list represents answers from five groups:


 - The first group contains one person who answered "yes" to <em><code>3</code></em> questions: <code>a</code>, <code>b</code>, and <code>c</code>.
 - The second group contains three people; combined, they answered "yes" to <em><code>3</code></em> questions: <code>a</code>, <code>b</code>, and <code>c</code>.
 - The third group contains two people; combined, they answered "yes" to <em><code>3</code></em> questions: <code>a</code>, <code>b</code>, and <code>c</code>.
 - The fourth group contains four people; combined, they answered "yes" to only <em><code>1</code></em> question, <code>a</code>.
 - The last group contains one person who answered "yes" to only <em><code>1</code></em> question, <code>b</code>.

In this example, the sum of these counts is <code>3 + 3 + 3 + 1 + 1</code> = <em><code>11</code></em>.

For each group, count the number of questions to which anyone answered "yes". <em>What is the sum of those counts?</em>


