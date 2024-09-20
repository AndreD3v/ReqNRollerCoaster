# ReqNRollerCoaster
Welcome to the Parallel Testing Deepdive!

A wild ride through the ups and downs of parallelizing software tests with reqNroll in C#. Buckle up as we dive into practical examples, best practices, and hands-on exercises to make your testing smoother, faster, and more efficient! Perfect for anyone looking to add some speed to their testing workflow.

This guide will help you set up your environment and understand the key components used in this deepdive.

## Prerequisites

### ReqNroll Extension

To participate in this deepdive, you need to install the ReqNroll extension. This extension provides enhanced functionality for running tests using Behavior Driven Development (BDD) principles. ReqNroll is the successor to SpecFlow, a popular Gherkin-based tool for .NET. I decided to move away from SpecFlow after reading below article, which explains the challenges with SpecFlow's development and how ReqNroll offers modern updates and better community support, while maintaining compatibility with existing projects.

For more background, check the article https://reqnroll.net/news/2024/02/from-specflow-to-reqnroll-why-and-how/.

#### Installation

1. Open Visual Studio.
2. Go to **Extensions** > **Manage Extensions**.
3. Search for **ReqNroll**.
4. Click **Download** and follow the prompts to install the extension.
5. Restart Visual Studio to complete the installation.

### Disabling SpecFlow Extension

If you already have the SpecFlow extension installed, you need to disable it to avoid conflicts with ReqNroll.

#### Disabling SpecFlow

1. Open Visual Studio.
2. Go to **Extensions** > **Manage Extensions**.
3. Find the **SpecFlow** extension in the list of installed extensions.
4. Click **Disable**.
5. Restart Visual Studio to apply the changes.

## Logging with Serilog

We use Serilog for logging in this deepdive. Serilog is a powerful logging library that allows us to capture detailed logs for our tests.

### How Serilog Works

Serilog is configured to log messages to both the console and a file. The log entries include useful information such as timestamps, log levels, and custom properties like `LogScope`. The logging configuration is set up in the `TestHooks.cs` file.

### Finding the Log Files

The log files are stored in the `logfiles` directory within the project `bin` directory. Each log file is named with a timestamp to ensure uniqueness.

## Parallel Execution

We have configured the tests to run in parallel to improve efficiency and reduce execution time. This is achieved using the NUnit `Parallelizable` attribute.

## Conclusion

By following this guide, you should be able to set up your environment for the Parallel Testing deepdive. If you have any questions or run into issues, please don't hesitate to ask for help. Happy testing!
