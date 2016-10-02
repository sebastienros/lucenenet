using NUnit.Framework;

namespace Lucene.Net.Codecs.Lucene42
{
    /*
         * Licensed to the Apache Software Foundation (ASF) under one or more
         * contributor license agreements.  See the NOTICE file distributed with
         * this work for additional information regarding copyright ownership.
         * The ASF licenses this file to You under the Apache License, Version 2.0
         * (the "License"); you may not use this file except in compliance with
         * the License.  You may obtain a copy of the License at
         *
         *     http://www.apache.org/licenses/LICENSE-2.0
         *
         * Unless required by applicable law or agreed to in writing, software
         * distributed under the License is distributed on an "AS IS" BASIS,
         * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
         * See the License for the specific language governing permissions and
         * limitations under the License.
         */

    using BaseCompressingDocValuesFormatTestCase = Lucene.Net.Index.BaseCompressingDocValuesFormatTestCase;

    /// <summary>
    /// Tests Lucene42DocValuesFormat
    /// </summary>
    public class TestLucene42DocValuesFormat : BaseCompressingDocValuesFormatTestCase
    {
        private Codec Codec_Renamed;

        /// <summary>
        /// LUCENENET specific
        /// Is non-static because OLD_FORMAT_IMPERSONATION_IS_ACTIVE is no longer static.
        /// </summary>
        [TestFixtureSetUp]
        public void BeforeClass()
        {
            OLD_FORMAT_IMPERSONATION_IS_ACTIVE = true; // explicitly instantiates ancient codec
            Codec_Renamed = new Lucene42RWCodec(OLD_FORMAT_IMPERSONATION_IS_ACTIVE);
        }

        protected override Codec Codec
        {
            get
            {
                return Codec_Renamed;
            }
        }

        protected internal override bool CodecAcceptsHugeBinaryValues(string field)
        {
            return false;
        }
    }
}