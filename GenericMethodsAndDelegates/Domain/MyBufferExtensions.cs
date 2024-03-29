﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericMethodsAndDelegates.Domain
{
     public static class MyBufferExtensions
    {
        public static void Dump<T>(this IBuffer<T> buffer, Action<T> print)
        {
            foreach (var item in buffer)
            {
                print(item);
            }
        }
        public static IEnumerable<TOutput> Map<T, TOutput>(
            this IBuffer<T> buffer, Converter<T, TOutput> converter)
        {
            return buffer.Select(i => converter(i));
        }
    }
}