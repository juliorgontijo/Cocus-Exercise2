The original exercise<br/><br/>

<pre><code class="language-csharp">
if (message is MessageA)
{
    var messageA = message as MessageA;
    messageA?.MyCustomMethodOnA();
}
else if (message is MessageB)
{
    var messageB = message as MessageB;
    messageB?.MyCustomMethodOnB();
    messageB?.SomeAdditionalMethodOnB();
}
else if (message is MessageC)
{
    var messageC = message as MessageC;
    messageC?.MyCustomMethodOnC();
}
</code></pre>


<p>Is ineficient and does not follow the open/closed principle of SOLID.</p>
<p>The solution proposed on this repository offers a more elegant approach using polymorphism.</p>
