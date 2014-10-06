{*                                   *}
{*      Is this a dir or an item?    *}
{*                                   *}
{if is_array($dirWalk)}

   {*                                   *}
   {*      Iterate over children        *}
   {*                                   *}
   {foreach from=$dirWalk item=dir key=key}
   {include file="vc2013_fileRecurse.tpl" dirWalk=$dir dirName=$key dirPath="$dirPath$dirName/" depth=$depth+1}
   {/foreach}
   
{else}

   {*                                   *}
   {*      Output an item               *}
   {*                                   *}
   {capture assign="itemOut"}
   {* we don't compile some files. *}
   {if preg_match('/x86_32/i',$dirWalk->path)}
      <ClCompile Include="{$dirWalk->path|replace:'//':'/'|replace:'/':'\\'}">
	        <ExcludedFromBuild Condition="'$(Configuration)|$(Platform)'=='Debug|x64'">true</ExcludedFromBuild>
            <ExcludedFromBuild Condition="'$(Configuration)|$(Platform)'=='Release|x64'">true</ExcludedFromBuild>
      </ClCompile>
   {elseif preg_match('/x86_64/i',$dirWalk->path)}
      <ClCompile Include="{$dirWalk->path|replace:'//':'/'|replace:'/':'\\'}">
            <ExcludedFromBuild Condition="'$(Configuration)|$(Platform)'=='Debug|Win32'">true</ExcludedFromBuild>
			<ExcludedFromBuild Condition="'$(Configuration)|$(Platform)'=='Release|Win32'">true</ExcludedFromBuild>
      </ClCompile>
   {else}   
	   {if dontCompile($dirWalk->path, $projOutput)}
		  <ClCompile Include="{$dirWalk->path|replace:'//':'/'|replace:'/':'\\'}">
				<ExcludedFromBuild Condition="'$(Configuration)|$(Platform)'=='Debug|Win32'">true</ExcludedFromBuild>
				<ExcludedFromBuild Condition="'$(Configuration)|$(Platform)'=='Release|Win32'">true</ExcludedFromBuild>
				<ExcludedFromBuild Condition="'$(Configuration)|$(Platform)'=='Debug|x64'">true</ExcludedFromBuild>
				<ExcludedFromBuild Condition="'$(Configuration)|$(Platform)'=='Release|x64'">true</ExcludedFromBuild>
		  </ClCompile>
	   {else}
		  {if substr($dirWalk->path, -4, 4) == ".asm"}
			 <CustomBuild Include="{$dirWalk->path|replace:'//':'/'|replace:'/':'\\'}">
				  <Command Condition="'$(Configuration)|$(Platform)'=='Debug|Win32'">"..\..\..\..\..\Engine\bin\nasm\nasm.exe" -f win32 "%(FullPath)" -o "$(IntDir)%(Filename).obj"</Command>
				  <Command Condition="'$(Configuration)|$(Platform)'=='Debug|x64'">"..\..\..\..\..\Engine\bin\nasm\nasm.exe" -f win32 "%(FullPath)" -o "$(IntDir)%(Filename).obj"</Command>
				  <Outputs Condition="'$(Configuration)|$(Platform)'=='Debug|Win32'">$(IntDir)%(Filename).obj;%(Outputs)</Outputs>
				  <Outputs Condition="'$(Configuration)|$(Platform)'=='Debug|x64'">$(IntDir)%(Filename).obj;%(Outputs)</Outputs>
				  <Command Condition="'$(Configuration)|$(Platform)'=='Release|Win32'">"..\..\..\..\..\Engine\bin\nasm\nasm.exe" -f win32 "%(FullPath)" -o "$(IntDir)%(Filename).obj"</Command>
				  <Command Condition="'$(Configuration)|$(Platform)'=='Release|x64'">"..\..\..\..\..\Engine\bin\nasm\nasm.exe" -f win32 "%(FullPath)" -o "$(IntDir)%(Filename).obj"</Command>
				  <Outputs Condition="'$(Configuration)|$(Platform)'=='Release|Win32'">$(IntDir)%(Filename).obj;%(Outputs)</Outputs>
				  <Outputs Condition="'$(Configuration)|$(Platform)'=='Release|x64'">$(IntDir)%(Filename).obj;%(Outputs)</Outputs>
				  <ExcludedFromBuild Condition="'$(Configuration)|$(Platform)'=='Debug|x64'">true</ExcludedFromBuild>
				  <ExcludedFromBuild Condition="'$(Configuration)|$(Platform)'=='Release|x64'">true</ExcludedFromBuild>
			 </CustomBuild>
		  {elseif $projOutput->isSourceFile( $dirWalk->path ) }
			 <ClCompile Include="{$dirWalk->path|replace:'//':'/'|replace:'/':'\\'}" />      
		  {elseif $projOutput->isResourceFile( $dirWalk->path ) }
			 <ResourceCompile Include="{$dirWalk->path|replace:'//':'/'|replace:'/':'\\'}" />      
		  {else}
			 <ClInclude Include="{$dirWalk->path|replace:'//':'/'|replace:'/':'\\'}" />      
		  {/if}{* if path == "*.asm" *}   
	   {/if}{* if dontCompile() *}
   {/if}
   {/capture}
   {$itemOut|indent:$depth:"\t"}
   
{/if}