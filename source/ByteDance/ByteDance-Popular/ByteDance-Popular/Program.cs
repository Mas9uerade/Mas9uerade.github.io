﻿using System;
using System.Collections.Generic;
using ByteDancePopular;

namespace ByteDancePopular
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            //Console.WriteLine("Hello World!");
            Solution sol = new Solution();
            int[] arr = new int[] { -1, 5, -7, 2, -1, 0, 7, 6, 2, 4};
            sol.KConcatenationMaxSum(arr, 5);


            //LRUCache cache = new LRUCache(2);
            //cache.Put(1, 1);
            //cache.Put(2, 2);
            //cache.Get(1);       // 返回  1
            //cache.Put(3, 3);    // 该操作会使得密钥 2 作废
            //cache.Get(2);       // 返回 -1 (未找到)
            //cache.Put(4, 4);    // 该操作会使得密钥 1 作废
            //cache.Get(1);       // 返回 -1 (未找到)
            //cache.Get(3);       // 返回  3
            //cache.Get(4);       // 返回  4


            //LFUCache lFUCache = new LFUCache(0);
            //lFUCache.Put(0, 0);
            //lFUCache.Get(0);
            //lFUCache.Put(2, 2);
            //int p = lFUCache.Get(1);      // 返回 1
            //lFUCache.Put(3, 3);   // 去除键 2
            //p = lFUCache.Get(2);      // 返回 -1（未找到）
            //p = lFUCache.Get(3);      // 返回 3
            //lFUCache.Put(4, 4);   // 去除键 1
            //p = lFUCache.Get(1);      // 返回 -1（未找到）
            //p = lFUCache.Get(3);      // 返回 3
            //p = lFUCache.Get(4);      // 返回 4

        }
    }
}
