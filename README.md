AutoProxyDemo
=============

A simple demo about how to use AutoProxy

You need to set your local api url in the javascript into the ../Views/Home/Index.cshtml in order to
get the home page pulling the data correctly

    <script type="text/javascript">
        $(document).ready(function () {
            //Create the proxy
            var personsProxy = new PersonsProxy('<put your web api location>');
            
            //......
        });
    </script>

This is a [AutoProxy](https://github.com/Yoinbol/AutoProxy) demo