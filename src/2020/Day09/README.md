original source: [https://adventofcode.com/2020/day/9](https://adventofcode.com/2020/day/9)
## --- Day 9: Encoding Error ---
With your neighbor happily enjoying their video game, you turn your attention to an open data port on the little screen in the seat in front of you.

Though the port is non-standard, you manage to connect it to your computer through the clever use of several paperclips. Upon connection, the port outputs a series of numbers (your puzzle input).

The data appears to be encrypted with the eXchange-Masking Addition System (XMAS) which, conveniently for you, is an old cypher with an important weakness.

XMAS starts by transmitting a <em>preamble</em> of 25 numbers. After that, each number you receive should be the sum of any two of the 25 immediately previous numbers. The two numbers will have different values, and there might be more than one such pair.

For example, suppose your preamble consists of the numbers <code>1</code> through <code>25</code> in a random order. To be valid, the next number must be the sum of two of those numbers:


 - <code>26</code> would be a <em>valid</em> next number, as it could be <code>1</code> plus <code>25</code> (or many other pairs, like <code>2</code> and <code>24</code>).
 - <code>49</code> would be a <em>valid</em> next number, as it is the sum of <code>24</code> and <code>25</code>.
 - <code>100</code> would <em>not</em> be valid; no two of the previous 25 numbers sum to <code>100</code>.
 - <code>50</code> would also <em>not</em> be valid; although <code>25</code> appears in the previous 25 numbers, the two numbers in the pair must be different.

Suppose the 26th number is <code>45</code>, and the first number (no longer an option, as it is more than 25 numbers ago) was <code>20</code>. Now, for the next number to be valid, there needs to be some pair of numbers among <code>1</code>-<code>19</code>, <code>21</code>-<code>25</code>, or <code>45</code> that add up to it:


 - <code>26</code> would still be a <em>valid</em> next number, as <code>1</code> and <code>25</code> are still within the previous 25 numbers.
 - <code>65</code> would <em>not</em> be valid, as no two of the available numbers sum to it.
 - <code>64</code> and <code>66</code> would both be <em>valid</em>, as they are the result of <code>19+45</code> and <code>21+45</code> respectively.

Here is a larger example which only considers the previous <em>5</em> numbers (and has a preamble of length 5):

<pre>
<code>35
20
15
25
47
40
62
55
65
95
102
117
150
182
127
219
299
277
309
576
</code>
</pre>

In this example, after the 5-number preamble, almost every number is the sum of two of the previous 5 numbers; the only number that does not follow this rule is <em><code>127</code></em>.

The first step of attacking the weakness in the XMAS data is to find the first number in the list (after the preamble) which is <em>not</em> the sum of two of the 25 numbers before it. <em>What is the first number that does not have this property?</em>


