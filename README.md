# EFCore.Transactions

## Overview

This repository contains the implementation of transaction handling in Entity Framework Core. It provides middleware and services to manage database transactions effectively.

## Files

### TransactionMiddleware
The `TransactionMiddleware` is responsible for managing the lifecycle of database transactions. It ensures that transactions are started, committed, or rolled back based on the execution flow of the application.

### TransactionService
The `TransactionService` provides an abstraction for working with transactions. It simplifies the process of managing transactions and integrates seamlessly with the middleware to ensure consistency and reliability.

## Usage

1. Add the `TransactionMiddleware` to your application's middleware pipeline.
2. Use the `TransactionService` in your application to manage transactions programmatically.
