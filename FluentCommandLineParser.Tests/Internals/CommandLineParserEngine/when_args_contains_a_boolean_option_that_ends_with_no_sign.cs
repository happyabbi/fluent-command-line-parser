﻿using Machine.Specifications;
using System.Collections.Generic;

namespace Fclp.Tests
{
    namespace CommandLineParserEngine
    {
        class when_args_contains_a_boolean_option_that_ends_with_no_sign : CommandLineParserEngineTestContext
        {
            static KeyValuePair<string, string> expected = new KeyValuePair<string, string>("key", null);

            Establish context = () => args = new[] { "/key" };

            Because of = () => RunParserWith(args);

            It should_return_key_with_null_value = () => results.ShouldContainOnly(expected);
        }
    }
}