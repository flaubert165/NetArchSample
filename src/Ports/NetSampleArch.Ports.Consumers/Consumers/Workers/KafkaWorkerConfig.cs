﻿using System;

namespace NetSampleArch.Ports.Consumers.Workers
{
    public class KafkaWorkerConfig
    {
        public (string ConsumerGroupId, string TopicName, Type Type)[] ConsumersConfig { get; }

        public KafkaWorkerConfig((string ConsumerGroupId, string TopicName, Type Type)[] consumersConfig)
        {
            ConsumersConfig = consumersConfig;
        }
    }
}
