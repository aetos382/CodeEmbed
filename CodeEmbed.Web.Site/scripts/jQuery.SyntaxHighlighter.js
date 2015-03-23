(function ($) {

    "use strict";

    var u = (function (_) { return _; })(); // undefined

    $.fn.SyntaxHighlight = function (/* string */ brush, /* object */ config, /* bool */ autoHighlight) {

        if (autoHighlight == u) { autoHighlight = true; }

        var classes = ["brush:" + brush];

        if (config) {

            var options = {
                autoLinks: "auto-links",
                className: "class-name",
                collapse: "collapse",
                firstLine: "first-line",
                gutter: "gutter",
                highlight: function (value) { return "highlight:[" + value.join(",") + "]"; },
                htmlScript: "html-script",
                light: "light",
                padLineNumbers: "pad-line-numbers",
                quickCode: "quick-code",
                smartTabs: "smart-tabs",
                tabSize: "tab-size",
                title: "title",
                toolbar: "toolbar"
            };

            $.each(config, function (name, value) {

                var x = options[name];
                var c;

                if (x == u) {
                    if (typeof value == "function") {
                        c = value(element);
                    }
                    else {
                        c = name + ":" + value;
                    }
                }
                else if (typeof x == "function") {
                    c = x(value);
                }
                else {
                    c = x + ":" + value;
                }

                classes.push(c);
            });

        }

        return this.each(function () {
            var element = $(this);

            $.each(classes, function () {
                element.addClass(this);
            });

            if (autoHighlight) {
                SyntaxHighlighter.highlight(null, element[0]);
            }
        });
    };

})(jQuery);

