﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace bfs.Repository.Storage {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class StorageResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal StorageResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("bfs.Repository.Storage.StorageResources", typeof(StorageResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot change reading direction when in non-sequential state..
        /// </summary>
        internal static string CannotChangeReadingDirectionWhenNonSequential {
            get {
                return ResourceManager.GetString("CannotChangeReadingDirectionWhenNonSequential", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The repository cannot be changed once set..
        /// </summary>
        internal static string CannotChangeRepoInFactory {
            get {
                return ResourceManager.GetString("CannotChangeRepoInFactory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot delete folder {0} because it contains subfolders..
        /// </summary>
        internal static string CannotDeleteFolderWithSubfolders {
            get {
                return ResourceManager.GetString("CannotDeleteFolderWithSubfolders", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot modify folder {0} while data in it is being accessed..
        /// </summary>
        internal static string CannotModifyFolderWhileDataIsAccessed {
            get {
                return ResourceManager.GetString("CannotModifyFolderWhileDataIsAccessed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Root folder is virtual and cannot be moved or removed..
        /// </summary>
        internal static string CannotMoveRootRepoFolder {
            get {
                return ResourceManager.GetString("CannotMoveRootRepoFolder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The folder instance is different from the one registered in the list of child folders..
        /// </summary>
        internal static string ChildFolderInstanceByNameMismatch {
            get {
                return ResourceManager.GetString("ChildFolderInstanceByNameMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Coder code is empty or null..
        /// </summary>
        internal static string CoderCodeEmpty {
            get {
                return ResourceManager.GetString("CoderCodeEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Repository file container notified about deletion of file with id {0:X} ({1:o}) which is not known to the container.
        /// </summary>
        internal static string ContainerNotifiedOfDeletionOfUnknownFile {
            get {
                return ResourceManager.GetString("ContainerNotifiedOfDeletionOfUnknownFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Context is inconsistent with the pending transaction..
        /// </summary>
        internal static string ContextInconsistentWithPendingTransaction {
            get {
                return ResourceManager.GetString("ContextInconsistentWithPendingTransaction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Concurrent data modification detected: data file {0} was not found..
        /// </summary>
        internal static string DataFileNotFound {
            get {
                return ResourceManager.GetString("DataFileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The data folders depth must be Hour, Day or Month..
        /// </summary>
        internal static string DataFoldersDepthInvalid {
            get {
                return ResourceManager.GetString("DataFoldersDepthInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified value violates containing data folder constraints.
        /// </summary>
        internal static string DataFolderTimeRangeViolation {
            get {
                return ResourceManager.GetString("DataFolderTimeRangeViolation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Data integrity violation detected..
        /// </summary>
        internal static string DataIntegrityViolationDetected {
            get {
                return ResourceManager.GetString("DataIntegrityViolationDetected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Data is not loaded.
        /// </summary>
        internal static string DataIsNotLoaded {
            get {
                return ResourceManager.GetString("DataIsNotLoaded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Descendant folder with relative path {0} was not found in {1}..
        /// </summary>
        internal static string DescendantFolderNotFound {
            get {
                return ResourceManager.GetString("DescendantFolderNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Objects belong to different repositories.
        /// </summary>
        internal static string DifferentRepositoriesException {
            get {
                return ResourceManager.GetString("DifferentRepositoriesException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A compressor with the same code is already registered..
        /// </summary>
        internal static string DuplicateCompressorCode {
            get {
                return ResourceManager.GetString("DuplicateCompressorCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An encryptor with the same code is already registered..
        /// </summary>
        internal static string DuplicateEncryptorCode {
            get {
                return ResourceManager.GetString("DuplicateEncryptorCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The option cannot be set after writing data..
        /// </summary>
        internal static string ErOptionCannotBeSetAfterWriting {
            get {
                return ResourceManager.GetString("ErOptionCannotBeSetAfterWriting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified file was not found in container.
        /// </summary>
        internal static string FileNotFoundInContainer {
            get {
                return ResourceManager.GetString("FileNotFoundInContainer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The folder already contains a child folder with the same name..
        /// </summary>
        internal static string FolderAlreadyContainsChildWithTheSameName {
            get {
                return ResourceManager.GetString("FolderAlreadyContainsChildWithTheSameName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Folder with the specified name already exists..
        /// </summary>
        internal static string FolderAlreadyExistsException {
            get {
                return ResourceManager.GetString("FolderAlreadyExistsException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Folder instance is invalid; it does not implement the required interface..
        /// </summary>
        internal static string FolderInstanceDoesNotImplementIFolder {
            get {
                return ResourceManager.GetString("FolderInstanceDoesNotImplementIFolder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The folder instance is not part of a repository..
        /// </summary>
        internal static string FolderIsNotPartOfARepository {
            get {
                return ResourceManager.GetString("FolderIsNotPartOfARepository", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Internal error: folder keys between this folder and its ancestor are inconsistent..
        /// </summary>
        internal static string FolderKeyInconsistentWithAncestor {
            get {
                return ResourceManager.GetString("FolderKeyInconsistentWithAncestor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified folder {0} was not found..
        /// </summary>
        internal static string FolderNotFound {
            get {
                return ResourceManager.GetString("FolderNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Illegal characters in the coder code..
        /// </summary>
        internal static string IllegalCharactersInCoderЦоде {
            get {
                return ResourceManager.GetString("IllegalCharactersInCoderЦоде", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Incompatible {0} version (expected: {1}, found: {2}).
        /// </summary>
        internal static string IncompatibleVersion {
            get {
                return ResourceManager.GetString("IncompatibleVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Internal error: file container index is corrupt.
        /// </summary>
        internal static string InternalErrorFileContainerIndexCorrupt {
            get {
                return ResourceManager.GetString("InternalErrorFileContainerIndexCorrupt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File identifier is invalid - first item timestamp is greater than last..
        /// </summary>
        internal static string InvalidFileNamingFirstLast {
            get {
                return ResourceManager.GetString("InvalidFileNamingFirstLast", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Leaf folders cannot have child folders.
        /// </summary>
        internal static string LeafFoldersCannotHaveChildFolders {
            get {
                return ResourceManager.GetString("LeafFoldersCannotHaveChildFolders", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified level does not represent descendants of this folder..
        /// </summary>
        internal static string LevelOfDescendantRequired {
            get {
                return ResourceManager.GetString("LevelOfDescendantRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File {0} overlaps with the existing file {1} in the container ({2})..
        /// </summary>
        internal static string OverlappingFileInContainer {
            get {
                return ResourceManager.GetString("OverlappingFileInContainer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Overlapping files exist in the container.
        /// </summary>
        internal static string OverlappingFilesInContainer {
            get {
                return ResourceManager.GetString("OverlappingFilesInContainer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Overlapping items detected.
        /// </summary>
        internal static string OverlappingItemsDetected {
            get {
                return ResourceManager.GetString("OverlappingItemsDetected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Position for the folder already exists in repository reading position.
        /// </summary>
        internal static string PositionForFolderAlreadyExists {
            get {
                return ResourceManager.GetString("PositionForFolderAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An issue is detected which may be related to a conflicting concurrent data update..
        /// </summary>
        internal static string PotentialConcurrencyIssueMessage {
            get {
                return ResourceManager.GetString("PotentialConcurrencyIssueMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The reader is disposed..
        /// </summary>
        internal static string ReaderIsDisposed {
            get {
                return ResourceManager.GetString("ReaderIsDisposed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Timestamp of the last item read from data file {0} in folder {1} does not match file name. Expected: {2:o}, actual: {3:o}..
        /// </summary>
        internal static string ReaderLastItemTimeInFileMismatch {
            get {
                return ResourceManager.GetString("ReaderLastItemTimeInFileMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Target folders not specified..
        /// </summary>
        internal static string ReaderTargetFoldersMissing {
            get {
                return ResourceManager.GetString("ReaderTargetFoldersMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Override mode must be ON..
        /// </summary>
        internal static string RepoFileAccessorMustBeInOverrideMode {
            get {
                return ResourceManager.GetString("RepoFileAccessorMustBeInOverrideMode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The repository instance is disposed..
        /// </summary>
        internal static string RepositoryIsDisposed {
            get {
                return ResourceManager.GetString("RepositoryIsDisposed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Data item count written in the header of the file {0} is {1}, but actual number of items was {2}..
        /// </summary>
        internal static string TechInfoDataItemCountMismatch {
            get {
                return ResourceManager.GetString("TechInfoDataItemCountMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Transactions are not supported..
        /// </summary>
        internal static string TransactionsNotSupported {
            get {
                return ResourceManager.GetString("TransactionsNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown compressor [{0}]. Please register the associated compressor in the repository manager&apos;s object factory..
        /// </summary>
        internal static string UnknownCompressor_Name {
            get {
                return ResourceManager.GetString("UnknownCompressor_Name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown encryptor [{0}]. Please register the associated encryptor in the repository manager&apos;s object factory..
        /// </summary>
        internal static string UnknownEncryptor_Name {
            get {
                return ResourceManager.GetString("UnknownEncryptor_Name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The unsaved items tracking is turned OFF.
        /// </summary>
        internal static string UnsavedItemsTrackingIsOff {
            get {
                return ResourceManager.GetString("UnsavedItemsTrackingIsOff", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Data file format version ({0}) is greater than the supported version ({1}.
        /// </summary>
        internal static string UnsupportedDataFileFormatVersion {
            get {
                return ResourceManager.GetString("UnsupportedDataFileFormatVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Virtual root data folder does not support this operation..
        /// </summary>
        internal static string VirtualRootInvalidOperation {
            get {
                return ResourceManager.GetString("VirtualRootInvalidOperation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Writer already exists for the folder {0}.
        /// </summary>
        internal static string WriterAlreadyExistsForFolder {
            get {
                return ResourceManager.GetString("WriterAlreadyExistsForFolder", resourceCulture);
            }
        }
    }
}
