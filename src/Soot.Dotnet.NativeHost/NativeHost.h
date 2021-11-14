// Standard headers
#ifndef NATIVEHOST_NATIVEHOST_H
#define NATIVEHOST_NATIVEHOST_H

#include <stdio.h>
#include <stdint.h>
#include <stdlib.h>
#include <string.h>
#include <assert.h>
#include <iostream>

#include "inc/Settings.h"
#include <vector>
#include "inc/cli_byte_array.h"
#include "cli_string.h"

// Provided by the AppHost NuGet package and installed as an SDK pack
#include <nethost.h>

#include <coreclr_delegates.h>
#include <hostfxr.h>

#ifdef WINDOWS
#include <Windows.h>

#define STR(s) L ## s
#define CH(c) L ## c
#define DIR_SEPARATOR L'\\'

#else
#include <dlfcn.h>
#include <limits.h>

#define STR(s) s
#define CH(c) c
#define DIR_SEPARATOR '/'
#define MAX_PATH PATH_MAX

#endif

using string_t = std::basic_string<char_t>;


class NativeHost
{
private:

    // Globals to hold hostfxr exports
    hostfxr_initialize_for_runtime_config_fn init_fptr{};
    hostfxr_get_runtime_delegate_fn get_delegate_fptr{};
    hostfxr_close_fn close_fptr{};

//    hostfxr_initialize_for_dotnet_command_line_fn init_fptr_new{};
//    hostfxr_run_app_fn run_app_fptr;
//    hostfxr_get_runtime_properties_fn hostfxr_get_runtime_properties;

    // Forward declarations
    bool load_hostfxr();
    load_assembly_and_get_function_pointer_fn get_dotnet_load_assembly(const char_t *assembly);

    // Forward declarations
    static void *load_library(const char_t *);
    static void *get_export(void *, const char *);

    string_t root_path;
    Settings settings;
    load_assembly_and_get_function_pointer_fn load_assembly_and_get_function_pointer = nullptr;

    /*
     * Initialize all given methods and variables for the dotnet hoster
     */
    void init();

public:
    explicit NativeHost(const std::string&);
    bool AssemblyProvider_isAssembly(const std::string&);
    cli_byte_array AssemblyProvider_getAllTypesMsg(cli_byte_array&);
    cli_byte_array AssemblyProvider_GetMethodBodyMsg(cli_byte_array&);
    cli_byte_array AssemblyProvider_GetMethodBodyOfPropertyMsg(cli_byte_array&);
    cli_byte_array AssemblyProvider_GetMethodBodyOfEventMsg(cli_byte_array&);
    cli_byte_array AssemblyProvider_GetAssemblyContent(cli_byte_array&);
};

#endif
